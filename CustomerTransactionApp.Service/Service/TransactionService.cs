using CustomerTransactionApp.Service.Helpers;
using CustomerTransactionApp.Service.Interface;
using CustomerTransactionApp.Service.Models;
using CustomerTransactionApp.Service.Models.DTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
namespace CustomerTransactionApp.Service.Service
{
    public class TransactionService : ITransaction
    {
        private readonly IConfiguration _configuration;

        public TransactionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Customer> GetCustomers()
        {
            var transactions = LoadJson();
            List<Customer> customers = TransformCustomerData(transactions);
            return customers;
        }
        private static List<Customer> TransformCustomerData(TransactionModel transactions)
        {
            var customers = new List<Customer>();
            foreach (var transaction in transactions?.Accounts)
            {
                customers.Add(new Customer
                {
                    AccountHolderNames = transaction.AccountHolderNames,
                    AccountId = transaction.AccountId,
                    AccountNumber = transaction.Identifiers?.AccountNumber,
                    AccountSubType = transaction.AccountSubType,
                    AccountType = transaction.AccountType,
                    AvailableBalance = transaction.Balances?.Available?.Amount,
                    BankCode = transaction.Identifiers?.BankCode,
                    CurrencyCode = transaction.CurrencyCode,
                    CurrentBalance = transaction.Balances?.Current?.Amount
                });
            }

            return customers;
        }

        public TransactionDetail GetTransactions(string id, DateTime? search)
        {
            //Closing balance = (Opening balance + Total Receipts (Credit)) - Total Payments (Debit)
            var transactions = LoadJson();
            var model = new TransactionDetail { Transactions = new List<TransactionItem>() };
            FilteredTransaction(id, search, transactions, model);
            return model;
        }

        private static void FilteredTransaction(string id, DateTime? search, TransactionModel? transactions, TransactionDetail model)
        {
            if (search != null)
            {
                DateTime date;
                if (DateTime.TryParse(search.ToString(), out date))
                {
                    model.OpeningBalance = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?.Balances?.Current?.Amount;
                    var filteredTransactions = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?
                        .Transactions?.Where(x => x.BookingDate <= date).ToList();
                    model.TotalCredit = filteredTransactions?.Where(x => x.CreditDebitIndicator == CreditDebitIndicator.Credit).Sum(s => s.Amount) + model.OpeningBalance;
                    model.TotalDebit = filteredTransactions?.Where(x => x.CreditDebitIndicator == CreditDebitIndicator.Debit).Sum(x => x.Amount);
                    model.ClosingBalance = model.TotalCredit - model.TotalDebit;
                    model.AccountHolderNames = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?.AccountHolderNames;
                    model.AccountId = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?.AccountId;
                    model.AccountNumber = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?.Identifiers?.AccountNumber;
                    model.CurrencyCode = transactions?.Accounts?.FirstOrDefault(x => x.AccountId == id)?.CurrencyCode;
                    model.Message = $"Transactions between {filteredTransactions?.OrderBy(x => x.BookingDate).FirstOrDefault().BookingDate.ToString("dd-MMM-yyyy")} AND {DateTime.Parse(search.ToString()):dd-MMM-yyyy}. Total transaction count is {filteredTransactions?.Count}";
                    foreach (var transaction in filteredTransactions.OrderBy(x => x.BookingDate))
                    {
                        model.Transactions.Add(new TransactionItem
                        {
                            Amount = transaction.Amount,
                            BookingDate = transaction.BookingDate,
                            CreditDebitIndicator = transaction.CreditDebitIndicator,
                            Description = transaction.Description,
                            Status = transaction.Status,
                            TransactionId = transaction.TransactionId
                        });

                    }
                }
            }
        }

        private TransactionModel LoadJson()
        {
            TransactionModel model;
            using (StreamReader r = new StreamReader(_configuration.GetSection("AppSettings:DataPath").Value))
            {
                string json = r.ReadToEnd();
                model = JsonConvert.DeserializeObject<TransactionModel>(json);
            }
            return model;
        }
    }
}

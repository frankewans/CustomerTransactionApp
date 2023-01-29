
using CustomerTransactionApp.Service.Models.DTO;
using System.Dynamic;

namespace CustomerTransactionApp.Service.Interface
{
    public interface ITransaction
    {
        public List<Customer> GetCustomers();
        public TransactionDetail GetTransactions(string id, DateTime? search);
    }
}

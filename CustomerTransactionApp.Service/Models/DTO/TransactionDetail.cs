namespace CustomerTransactionApp.Service.Models.DTO
{
    public class TransactionDetail
    {
        public string? AccountNumber { get; set; }
        public string? AccountId { get; set; }
        public string? CurrencyCode { get; set; }
        public string? AccountHolderNames { get; set; }
        public double? OpeningBalance { get; set; }
        public double? ClosingBalance { get; set; }
        public double? TotalCredit { get; set; }
        public double? TotalDebit { get; set; }
        public string? Message { get; set; }
        public List<TransactionItem>? Transactions { get; set; }
    }
}

namespace CustomerTransactionApp.Service.Models.DTO
{
    public class Customer
    {
        public string? AccountHolderNames { get; set; }
        public string? AccountId { get; set; }
        public string? CurrencyCode { get; set; }       
        public string? AccountType { get; set; }
        public string? AccountSubType { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankCode { get; set; }
        public double? CurrentBalance { get; set; }
        public double? AvailableBalance { get; set; }
    }
}

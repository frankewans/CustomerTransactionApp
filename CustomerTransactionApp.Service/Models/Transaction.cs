using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Transaction
    {
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("creditDebitIndicator")]
        public string? CreditDebitIndicator { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("transactionCode")]
        public TransactionCode? TransactionCode { get; set; }

        [JsonProperty("proprietaryTransactionCode")]
        public object? ProprietaryTransactionCode { get; set; }

        [JsonProperty("bookingDate")]
        public DateTime BookingDate { get; set; }

        [JsonProperty("merchantDetails")]
        public MerchantDetails? MerchantDetails { get; set; }

        [JsonProperty("enrichedData")]
        public EnrichedData? EnrichedData { get; set; }
    }


}

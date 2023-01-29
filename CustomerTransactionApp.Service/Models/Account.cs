using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    // TransactionModel TransactionModel = JsonConvert.DeserializeObject<TransactionModel>(myJsonResponse);
    public class Account
    {
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        [JsonProperty("accountHolderNames")]
        public string? AccountHolderNames { get; set; }

        [JsonProperty("accountType")]
        public string? AccountType { get; set; }

        [JsonProperty("accountSubType")]
        public string? AccountSubType { get; set; }

        [JsonProperty("identifiers")]
        public Identifiers? Identifiers { get; set; }

        [JsonProperty("parties")]
        public List<Party>? Parties { get; set; }

        [JsonProperty("balances")]
        public Balances? Balances { get; set; }

        [JsonProperty("transactions")]
        public List<Transaction>? Transactions { get; set; }
    }


}

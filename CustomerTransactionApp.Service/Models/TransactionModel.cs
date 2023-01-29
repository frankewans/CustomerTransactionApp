using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class TransactionModel
    {
        [JsonProperty("providerName")]
        public string? ProviderName { get; set; }

        [JsonProperty("countryCode")]
        public string? CountryCode { get; set; }

        [JsonProperty("accounts")]
        public List<Account>? Accounts { get; set; }
    }
}

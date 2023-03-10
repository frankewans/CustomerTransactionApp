using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Current
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("creditDebitIndicator")]
        public string? CreditDebitIndicator { get; set; }

        [JsonProperty("creditLines")]
        public List<object>? CreditLines { get; set; }
    }


}

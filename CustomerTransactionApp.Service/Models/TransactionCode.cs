using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class TransactionCode
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("subCode")]
        public string? SubCode { get; set; }
    }


}

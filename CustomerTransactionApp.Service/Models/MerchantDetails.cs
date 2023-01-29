using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class MerchantDetails
    {
        [JsonProperty("merchantName")]
        public string? MerchantName { get; set; }

        [JsonProperty("merchantCategoryCode")]
        public object? MerchantCategoryCode { get; set; }
    }


}

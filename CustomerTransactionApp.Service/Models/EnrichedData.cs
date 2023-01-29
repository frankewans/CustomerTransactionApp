using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class EnrichedData
    {
        [JsonProperty("category")]
        public Category? Category { get; set; }

        [JsonProperty("class")]
        public Class? Class { get; set; }

        [JsonProperty("predictedMerchantName")]
        public string? PredictedMerchantName { get; set; }
    }


}

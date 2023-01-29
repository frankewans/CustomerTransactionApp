using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Class
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }


}

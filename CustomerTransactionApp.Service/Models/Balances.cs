using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Balances
    {
        [JsonProperty("current")]
        public Current? Current { get; set; }

        [JsonProperty("available")]
        public Available? Available { get; set; }
    }


}

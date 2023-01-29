using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Identifiers
    {
        [JsonProperty("accountNumber")]
        public string? AccountNumber { get; set; }

        [JsonProperty("bankCode")]
        public string? BankCode { get; set; }

        [JsonProperty("iban")]
        public object? Iban { get; set; }

        [JsonProperty("secondaryIdentification")]
        public object? SecondaryIdentification { get; set; }
    }


}

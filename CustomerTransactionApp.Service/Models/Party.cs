using Newtonsoft.Json;

namespace CustomerTransactionApp.Service.Models
{
    public class Party
    {
        [JsonProperty("partyId")]
        public string? PartyId { get; set; }

        [JsonProperty("fullName")]
        public string? FullName { get; set; }

        [JsonProperty("addresses")]
        public List<object>? Addresses { get; set; }

        [JsonProperty("partyType")]
        public object? PartyType { get; set; }

        [JsonProperty("isIndividual")]
        public object? IsIndividual { get; set; }

        [JsonProperty("isAuthorizingParty")]
        public object? IsAuthorizingParty { get; set; }

        [JsonProperty("emailAddress")]
        public object? EmailAddress { get; set; }

        [JsonProperty("phoneNumbers")]
        public List<object>? PhoneNumbers { get; set; }
    }


}

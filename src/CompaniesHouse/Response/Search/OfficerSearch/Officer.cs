using Newtonsoft.Json;

namespace CompaniesHouse.Response.Search.OfficerSearch
{
    public class Officer : SearchItem
    {
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        [JsonProperty(PropertyName = "address_snippet")]
        public string AddressSnippet { get; set; }

        [JsonProperty(PropertyName = "appointment_count")]
        public int AppointmentCount { get; set; }

        [JsonProperty(PropertyName = "date_of_birth")]
        public DateOfBirth DateOfBirth { get; set; }
        
        [JsonProperty(PropertyName = "description_identifiers")]
        public DescriptionIdentifier[] DescriptionIdentifiers { get; set; }
    }
}
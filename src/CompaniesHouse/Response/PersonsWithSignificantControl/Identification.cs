using Newtonsoft.Json;

namespace CompaniesHouse.Response.PersonsWithSignificantControl
{
    public class Identification
    {
        [JsonProperty(PropertyName = "place_registered")]
        public string PlaceRegistered { get; set; }

        [JsonProperty(PropertyName = "registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty(PropertyName = "country_registered")]
        public string CountryRegistered { get; set; }

        [JsonProperty(PropertyName = "legal_authority")]
        public string LegalAuthority { get; set; }

        [JsonProperty(PropertyName = "legal_form")]
        public string LegalForm { get; set; }
    }
}

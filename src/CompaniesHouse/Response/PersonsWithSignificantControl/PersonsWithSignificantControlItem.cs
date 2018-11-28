using Newtonsoft.Json;
using System;

namespace CompaniesHouse.Response.PersonsWithSignificantControl
{
    public class PersonsWithSignificantControlItem
    {
        [JsonProperty(PropertyName = "country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Links Links { get; set; }

        [JsonProperty(PropertyName = "identification")]
        public Identification Identification { get; set; }

        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        [JsonProperty(PropertyName = "notified_on")]
        public DateTime? NotifiedOn { get; set; }

        [JsonProperty(PropertyName = "ceased_on")]
        public DateTime? CeasedOn { get; set; }

        [JsonProperty(PropertyName = "date_of_birth")]
        public DateOfBirth DateOfBirth { get; set; }

        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "name_elements")]
        public NameElements NameElements { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName = "natures_of_control")]
        public string[] NaturesOfControl { get; set; }

        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }
    }
}

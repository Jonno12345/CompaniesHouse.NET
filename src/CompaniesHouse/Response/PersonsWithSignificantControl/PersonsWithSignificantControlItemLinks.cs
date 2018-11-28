using Newtonsoft.Json;

namespace CompaniesHouse.Response.PersonsWithSignificantControl
{
    public class PersonsWithSignificantControlItemLinks : Links
    {
        [JsonProperty(PropertyName = "statement")]
        public string Statement { get; set; }
    }
}

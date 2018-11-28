using Newtonsoft.Json;

namespace CompaniesHouse.Response.PersonsWithSignificantControl
{
    public class PersonsWithSignificantControl : ListResult
    {
        [JsonProperty(PropertyName = "items")]
        public PersonsWithSignificantControlItem[] Items { get; set; }
    }
}

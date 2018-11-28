using Newtonsoft.Json;

namespace CompaniesHouse.Response
{
    public class Links
    {
        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }
    }
}
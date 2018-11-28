using Newtonsoft.Json;

namespace CompaniesHouse.Response
{
    public class NameElements
    {
        [JsonProperty(PropertyName = "forename")]
        public string Forename { get; set; }

        [JsonProperty(PropertyName = "other_forenames")]
        public string OtherForenames { get; set; }

        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}

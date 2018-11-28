using Newtonsoft.Json;

namespace CompaniesHouse.Response
{
    public class DateOfBirth
    {
        [JsonProperty(PropertyName = "month")]
        public int? Month { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int? Year { get; set; }
    }
}
using CompaniesHouse.JsonConverters;
using Newtonsoft.Json;

namespace CompaniesHouse.Response.Search
{
    [JsonConverter(typeof(SearchItemConverter))]
    public abstract class SearchItem
    {
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Links Links { get; set; }

        [JsonProperty(PropertyName = "matches")]
        public Matches Matches { get; set; }

        [JsonProperty(PropertyName = "snippet")]
        public string Snippet { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}

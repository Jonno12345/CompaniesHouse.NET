using CompaniesHouse.Response.Search;
using Newtonsoft.Json;

namespace CompaniesHouse.Response
{
    public abstract class ListResult
    {
        [JsonProperty(PropertyName = "links")]
        public Links Links { get; set; }

        [JsonProperty(PropertyName = "total_results")]
        public int TotalResults { get; set; }

        [JsonProperty(PropertyName = "items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty(PropertyName = "start_index")]
        public int StartIndex { get; set; }

        [JsonProperty(PropertyName = "ceased_count")]
        public int CeasedCount { get; set; }

        [JsonProperty(PropertyName = "active_count")]
        public int ActiveCount { get; set; }
    }
}

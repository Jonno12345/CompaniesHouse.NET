using Newtonsoft.Json;

namespace CompaniesHouse.Response.PersonsWithSignificantControl
{
    public class PersonsWithSignificantControlLinks : Links
    {
        [JsonProperty(PropertyName = "persons_with_significant_control_statements_list")]
        public string PersonsWithSignificantControlStatementsList { get; set; }
    }
}

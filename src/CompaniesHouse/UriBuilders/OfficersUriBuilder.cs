namespace CompaniesHouse.UriBuilders
{
    internal class OfficersListUriBuilder : ListUriBuilder
    {
        protected override string BaseUri { get; } = "company/{0}/officers";
    }
}

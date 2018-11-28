using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.UriBuilders
{
    internal class PersonsWithSignificantControlListUriBuilder : ListUriBuilder
    {
        protected override string BaseUri { get; } = "company/{0}/persons-with-significant-control";
    }
}

using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.UriBuilders
{
    internal class CompanyFilingHistoryListUriBuilder : ListUriBuilder
    {
        protected override string BaseUri { get; } = "company/{0}/filing-history";
    }
}

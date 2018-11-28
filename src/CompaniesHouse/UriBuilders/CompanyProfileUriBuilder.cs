using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.UriBuilders
{
    internal class CompanyProfileUriBuilder : CompanyNumberUriBuilder
    {
        protected override string BaseUri { get; } = "company/{0}";
    }
}

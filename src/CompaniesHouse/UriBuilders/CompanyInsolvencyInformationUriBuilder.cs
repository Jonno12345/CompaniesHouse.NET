using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.UriBuilders
{
    internal class CompanyInsolvencyInformationUriBuilder : CompanyNumberUriBuilder
    {
        protected override string BaseUri { get; } = "company/{0}/insolvency";
    }
}

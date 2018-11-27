using System;

namespace CompaniesHouse.UriBuilders
{
    internal class CompanyProfileUriBuilder : ICompanyProfileUriBuilder
    {
        public Uri Build(string companyNumber)
        {
            var path = "company/" + Uri.EscapeDataString(companyNumber);

            return new Uri(path, UriKind.Relative);
        }
    }
}

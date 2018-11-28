using System;

namespace CompaniesHouse.UriBuilders.Base
{
    internal abstract class CompanyNumberUriBuilder : ICompanyNumberUriBuilder
    {
        protected abstract string BaseUri { get; }

        public Uri Build(string companyNumber)
        {
            var path = string.Format(BaseUri, Uri.EscapeDataString(companyNumber));

            return new Uri(path, UriKind.Relative);
        }
    }
}

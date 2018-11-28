using System;

namespace CompaniesHouse.UriBuilders.Base
{
    internal interface ICompanyNumberUriBuilder
    {
        Uri Build(string companyNumber);
    }
}

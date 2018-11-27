using System;

namespace CompaniesHouse.UriBuilders
{
    internal interface ICompanyProfileUriBuilder
    {
        Uri Build(string companyNumber);
    }
}
using System;

namespace CompaniesHouse.UriBuilders
{
    internal interface IListUriBuilder
    {
        Uri Build(string companyNumber, int? startIndex, int? pageSize);
    }
}
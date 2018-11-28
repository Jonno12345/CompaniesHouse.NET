using System;

namespace CompaniesHouse.UriBuilders.Base
{
    internal interface IListUriBuilder
    {
        Uri Build(string companyNumber, int? startIndex, int? pageSize);
    }
}
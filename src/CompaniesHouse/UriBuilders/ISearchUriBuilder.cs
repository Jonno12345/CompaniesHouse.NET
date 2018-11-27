using System;
using CompaniesHouse.Request;

namespace CompaniesHouse.UriBuilders
{
    internal interface ISearchUriBuilder
    {
        Uri Build(SearchRequest request);
    }
}
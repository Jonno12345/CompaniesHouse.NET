using CompaniesHouse.UriBuilders;

namespace CompaniesHouse.Implementation.Interfaces
{
    internal interface ISearchUriBuilderFactory
    {
        ISearchUriBuilder Create<TSearch>();
    }
}
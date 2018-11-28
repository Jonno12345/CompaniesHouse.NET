using CompaniesHouse.UriBuilders;

namespace CompaniesHouse.Factories
{
    internal interface ISearchUriBuilderFactory
    {
        ISearchUriBuilder Create<TSearch>();
    }
}
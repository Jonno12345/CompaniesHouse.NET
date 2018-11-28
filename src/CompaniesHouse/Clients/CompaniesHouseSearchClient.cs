using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Extensions;
using CompaniesHouse.Factories;
using CompaniesHouse.Request;
using CompaniesHouse.Response;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHouseSearchClient : CompaniesHouseBaseClient
    {
        private readonly ISearchUriBuilderFactory _searchUriBuilderFactory;

        public CompaniesHouseSearchClient(HttpClient httpClient, ISearchUriBuilderFactory searchUriBuilderFactory) : base(httpClient)
        {
            _searchUriBuilderFactory = searchUriBuilderFactory;
        }

        public async Task<CompaniesHouseClientResponse<TSearch>> SearchAsync<TSearch>(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken)) where TSearch : class
        {
            var searchUriBuilder = _searchUriBuilderFactory.Create<TSearch>();
            var requestUri = searchUriBuilder.Build(request);

            return await GenerateResult<TSearch>(requestUri, cancellationToken);
        }
    }
}
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Extensions;
using CompaniesHouse.Implementation.Interfaces;
using CompaniesHouse.Request;
using CompaniesHouse.Response;

namespace CompaniesHouse.Implementation.Clients
{
    internal class CompaniesHouseSearchClient 
    {
        private readonly HttpClient _httpClient;
        private readonly ISearchUriBuilderFactory _searchUriBuilderFactory;

        public CompaniesHouseSearchClient(HttpClient httpClient, ISearchUriBuilderFactory searchUriBuilderFactory)
        {
            _httpClient = httpClient;
            _searchUriBuilderFactory = searchUriBuilderFactory;
        }

        public async Task<CompaniesHouseClientResponse<TSearch>> SearchAsync<TSearch>(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var searchUriBuilder = _searchUriBuilderFactory.Create<TSearch>();
            var requestUri = searchUriBuilder.Build(request);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsJsonAsync<TSearch>().ConfigureAwait(false);

            return new CompaniesHouseClientResponse<TSearch>(result);
        }
    }
}
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Extensions;
using CompaniesHouse.Response;
using CompaniesHouse.Response.Officers;
using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHouseOfficersClient : CompaniesHouseBaseClient
    {
        private readonly IListUriBuilder _officersUriBuilder;

        public CompaniesHouseOfficersClient(HttpClient httpClient, IListUriBuilder officersUriBuilder) : base(httpClient)
        {
            _officersUriBuilder = officersUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<Officers>> GetOfficersAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _officersUriBuilder.Build(companyNumber, startIndex, pageSize);

            return await GenerateResult<Officers>(requestUri, cancellationToken);

        }
    }
}
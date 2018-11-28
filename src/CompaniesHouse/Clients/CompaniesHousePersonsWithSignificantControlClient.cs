using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Extensions;
using CompaniesHouse.Response;
using CompaniesHouse.Response.PersonsWithSignificantControl;
using CompaniesHouse.UriBuilders.Base;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHousePersonsWithSignificantControlClient : CompaniesHouseBaseClient
    {
        private readonly IListUriBuilder _personsWithSignificantControlUriBuilder;

        public CompaniesHousePersonsWithSignificantControlClient(HttpClient httpClient, IListUriBuilder personsWithSignificantControlUriBuilder) : base(httpClient)
        {
            _personsWithSignificantControlUriBuilder = personsWithSignificantControlUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<PersonsWithSignificantControl>> GetPersonsWithSignificantControlAsync(string companyNumber, int? startIndex, int? pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlUriBuilder.Build(companyNumber, startIndex, pageSize);

            return await GenerateResult<PersonsWithSignificantControl>(requestUri, cancellationToken);

        }
    }
}
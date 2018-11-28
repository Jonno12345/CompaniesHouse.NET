using CompaniesHouse.Extensions;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyFiling;
using CompaniesHouse.UriBuilders.Base;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHouseCompanyFilingHistoryClient : CompaniesHouseBaseClient
    {
        private readonly IListUriBuilder _companyFilingHistoryUriBuilder;

        public CompaniesHouseCompanyFilingHistoryClient(HttpClient httpClient, IListUriBuilder companyFilingHistoryUriBuilder) 
            : base(httpClient)
        {
            _companyFilingHistoryUriBuilder = companyFilingHistoryUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanyFilingHistory>> GetCompanyFilingHistoryAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _companyFilingHistoryUriBuilder.Build(companyNumber, startIndex, pageSize);

            return await GenerateResult<CompanyFilingHistory>(requestUri, cancellationToken);
        }
    }
}
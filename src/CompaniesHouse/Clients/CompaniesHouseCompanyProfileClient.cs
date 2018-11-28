using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyProfile;
using CompaniesHouse.UriBuilders.Base;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHouseCompanyProfileClient : CompaniesHouseBaseClient
    {
        private readonly ICompanyNumberUriBuilder _companyProfileUriBuilder;

        public CompaniesHouseCompanyProfileClient(HttpClient httpClient, ICompanyNumberUriBuilder companyProfileUriBuilder) :base(httpClient)
        {
            _companyProfileUriBuilder = companyProfileUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanyProfile>> GetCompanyProfileAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _companyProfileUriBuilder.Build(companyNumber);

            return await GenerateResult<CompanyProfile>(requestUri, cancellationToken);
        }
    }
}
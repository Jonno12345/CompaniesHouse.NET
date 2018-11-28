using CompaniesHouse.Response;
using CompaniesHouse.Response.Insolvency;
using CompaniesHouse.UriBuilders;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CompaniesHouse.Clients
{
    internal class CompaniesHouseCompanyInsolvencyInformationClient : CompaniesHouseBaseClient
    {
        private readonly CompanyInsolvencyInformationUriBuilder _companyInsolvencyInformationUriBuilder;

        public CompaniesHouseCompanyInsolvencyInformationClient(HttpClient httpClient, CompanyInsolvencyInformationUriBuilder companyInsolvencyInformationUriBuilder) : base(httpClient)
        {
            _companyInsolvencyInformationUriBuilder = companyInsolvencyInformationUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanyInsolvencyInformation>> GetCompanyInsolvencyInformationAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _companyInsolvencyInformationUriBuilder.Build(companyNumber);

            return await GenerateResult<CompanyInsolvencyInformation>(requestUri, cancellationToken);
        }
    }
}
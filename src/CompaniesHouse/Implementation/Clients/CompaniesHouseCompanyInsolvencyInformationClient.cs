using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Extensions;
using CompaniesHouse.Response;
using CompaniesHouse.Response.Insolvency;

namespace CompaniesHouse.Implementation.Clients
{
    internal class CompaniesHouseCompanyInsolvencyInformationClient
    {
        private readonly HttpClient _httpClient;

        public CompaniesHouseCompanyInsolvencyInformationClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CompaniesHouseClientResponse<CompanyInsolvencyInformation>> GetCompanyInsolvencyInformationAsync(string companyNumber, CancellationToken cancellationToken = default (CancellationToken))
        {
            var requestUri = $"company/{companyNumber}/insolvency";

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
                
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsJsonAsync<CompanyInsolvencyInformation>().ConfigureAwait(false);

            return new CompaniesHouseClientResponse<CompanyInsolvencyInformation>(result);
        }
    }
}
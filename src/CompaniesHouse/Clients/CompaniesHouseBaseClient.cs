using CompaniesHouse.Extensions;
using CompaniesHouse.Response;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CompaniesHouse.Clients
{
    internal abstract class CompaniesHouseBaseClient
    {
        protected readonly HttpClient _httpClient;

        protected CompaniesHouseBaseClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected async Task<CompaniesHouseClientResponse<T>> GenerateResult<T>(Uri requestUri, CancellationToken cancellationToken) where T : class
        {
            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            T result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<T>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<T>(result, response);
        }
    }
}

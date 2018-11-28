using System.Net;
using System.Net.Http;
using CompaniesHouse.DelegatingHandlers;

namespace CompaniesHouse.Factories
{
    internal class HttpClientFactory : IHttpClientFactory
    {
        private readonly CompaniesHouseSettings _settings;

        public HttpClientFactory(CompaniesHouseSettings settings)
        {
            _settings = settings;
        }

        public HttpClient CreateHttpClient()
        {
            var httpClientHandler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var companiesHouseAuthorizationHandler = new CompaniesHouseAuthorizationHandler(_settings.ApiKey)
            {
                InnerHandler = httpClientHandler
            };

            var httpClient = new HttpClient(companiesHouseAuthorizationHandler)
            {
                BaseAddress = _settings.BaseUri
            };


            return httpClient;
        }
    }
}
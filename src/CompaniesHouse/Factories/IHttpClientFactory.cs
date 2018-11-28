using System.Net.Http;

namespace CompaniesHouse.Factories
{
    internal interface IHttpClientFactory
    {
        HttpClient CreateHttpClient();
    }
}
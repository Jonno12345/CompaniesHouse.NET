using System.Net.Http;

namespace CompaniesHouse
{
    internal interface IHttpClientFactory
    {
        HttpClient CreateHttpClient();
    }
}
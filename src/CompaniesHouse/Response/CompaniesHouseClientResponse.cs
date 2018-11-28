using System;
using System.Net.Http;

namespace CompaniesHouse.Response
{
    public class CompaniesHouseClientResponse<T>
    {
        public CompaniesHouseClientResponse(T data, HttpResponseMessage response)
        {
            Data = data;
            Response = response;
        }

        public T Data { get; }
        public HttpResponseMessage Response { get; }
    }
}
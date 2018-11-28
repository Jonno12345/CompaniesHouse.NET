using System;

namespace CompaniesHouse.UriBuilders.Base
{
    internal abstract class ListUriBuilder : CompanyNumberUriBuilder, IListUriBuilder
    {
        public Uri Build(string companyNumber, int? startIndex, int? pageSize)
        {
            var uri = Build(companyNumber).ToString();

            var queryString = "?";
            if (pageSize.HasValue)
            {
                queryString += $"items_per_page={pageSize}&";
            }

            if (startIndex.HasValue)
            {
                queryString += $"start_index={startIndex}&";
            }

            uri += queryString.Remove(queryString.Length - 1);

            return new Uri(uri, UriKind.Relative);
        }
    }
}

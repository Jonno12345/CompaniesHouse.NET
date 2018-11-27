using System;

namespace CompaniesHouse.UriBuilders
{
    internal abstract class ListUriBuilder : IListUriBuilder
    {
        protected abstract string BaseUri { get; }

        public Uri Build(string companyNumber, int? startIndex, int? pageSize)
        {
            var path = string.Format(BaseUri, Uri.EscapeDataString(companyNumber));
            var queryString = "?";
            if (pageSize.HasValue)
            {
                queryString += $"items_per_page={pageSize}&";
            }

            if (startIndex.HasValue)
            {
                queryString += $"start_index={startIndex}&";
            }

            path += queryString.Remove(queryString.Length - 1);

            return new Uri(path, UriKind.Relative);
        }
    }
}

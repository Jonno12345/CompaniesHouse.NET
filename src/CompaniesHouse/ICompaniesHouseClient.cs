using CompaniesHouse.Request;
using CompaniesHouse.Response.CompanyFiling;
using CompaniesHouse.Response.CompanyProfile;
using CompaniesHouse.Response.Insolvency;
using CompaniesHouse.Response.Officers;
using CompaniesHouse.Response.Search.AllSearch;
using CompaniesHouse.Response.Search.CompanySearch;
using CompaniesHouse.Response.Search.DisqualifiedOfficersSearch;
using CompaniesHouse.Response.Search.OfficerSearch;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response;

namespace CompaniesHouse
{
    public interface ICompaniesHouseClient
    {
        Task<CompaniesHouseClientResponse<CompanyInsolvencyInformation>> GetCompanyInsolvencyInformationAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<Officers>> GetOfficersAsync(string companyNumber, int startIndex = 0, int pageSize = 25, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<CompanyFilingHistory>> GetCompanyFilingHistoryAsync(string companyNumber, int startIndex = 0, int pageSize = 25, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<CompanyProfile>> GetCompanyProfileAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<AllSearch>> SearchAllAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<DisqualifiedOfficerSearch>> SearchDisqualifiedOfficerAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<OfficerSearch>> SearchOfficerAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
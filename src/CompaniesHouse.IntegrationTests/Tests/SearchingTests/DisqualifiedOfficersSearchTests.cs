using CompaniesHouse.Request;
using CompaniesHouse.Response;
using CompaniesHouse.Response.Search.DisqualifiedOfficersSearch;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.SearchingTests
{
    [TestFixture]
    public class DisqualifiedOfficersSearchTests
    {
        private CompaniesHouseClient _client;
        private CompaniesHouseClientResponse<DisqualifiedOfficerSearch> _result;
        
        [OneTimeSetUp]
        public void GivenACompaniesHouseClient()
        {
            var settings = new CompaniesHouseSettings(Keys.ApiKey);

            _client = new CompaniesHouseClient(settings);
        }

        [SetUp]
        public void WhenSearchingForADisqualifiedOfficers()
        {
            _result = _client.SearchDisqualifiedOfficerAsync(new SearchRequest() { Query = "Kevin" }).Result;
        }

        [Test]
        public void ThenDisqualifiedOfficersAreReturned()
        {
            Assert.That(_result.Data.DisqualifiedOfficers, Is.Not.Empty);
        }
    }
}
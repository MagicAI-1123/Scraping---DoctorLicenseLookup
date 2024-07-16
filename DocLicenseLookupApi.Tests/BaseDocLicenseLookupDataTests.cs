using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DocLicenseLookupApi.Tests
{
    public abstract class BaseDocLicenseLookupDataTests
    {

        protected DocLicenseLookupData _docLicenseLookupData;

        protected BaseDocLicenseLookupDataTests(string firstName, string lastName, bool isDOSearch) => _docLicenseLookupData = new DocLicenseLookupData(lastName, firstName, isDOSearch);

        protected void AssertLicenseNumberNotNullOrEmpty(IEnumerable<LicenseInfo> data)
        {
            var licenseNumber = data.FirstOrDefault()?.LicenseNumber;
            Assert.NotNull(licenseNumber);
            Assert.NotEmpty(licenseNumber);
        }

        [Fact]
        public async Task GetAlabamaTest()
        {
            var data = await _docLicenseLookupData.GetAlabamaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetAlaskaTest()
        {
            var data = await _docLicenseLookupData.GetAlaskaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetArizonaTest()
        {
            var data = await _docLicenseLookupData.GetArizonaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetArkansasTest()
        {
            var data = await _docLicenseLookupData.GetArkansasLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetCaliforniaTest()
        {
            var data = await _docLicenseLookupData.GetCaliforniaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetColoradoTest()
        {
            var data = await _docLicenseLookupData.GetColoradoLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetConnecticutTest()
        {
            var data = await _docLicenseLookupData.GetConnecticutLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetDelawareTest()
        {
            var data = await _docLicenseLookupData.GetDelawareLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetFloridaTest()
        {
            var data = await _docLicenseLookupData.GetFloridaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetGeorgiaTest()
        {
            var data = await _docLicenseLookupData.GetGeorgiaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetHawaiiTest()
        {
            var data = await _docLicenseLookupData.GetHawaiiLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetIdahoTest()
        {
            var data = await _docLicenseLookupData.GetIdahoLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetIllinoisTest()
        {
            var data = await _docLicenseLookupData.GetIllinoisLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetIndianaTest()
        {
            var data = await _docLicenseLookupData.GetIndianaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetIowaTest()
        {
            var data = await _docLicenseLookupData.GetIowaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetKansasTest()
        {
            var data = await _docLicenseLookupData.GetKansasLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetKentuckyTest()
        {
            var data = await _docLicenseLookupData.GetKentuckyLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetLouisianaTest()
        {
            var data = await _docLicenseLookupData.GetLouisianaSiteLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMaineTest()
        {
            var data = await _docLicenseLookupData.GetMaineSiteLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMarylandTest()
        {
            var data = await _docLicenseLookupData.GetMarylandLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMassachusettsTest()
        {
            var data = await _docLicenseLookupData.GetMarylandLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMichiganTest()
        {
            var data = await _docLicenseLookupData.GetMichiganSiteLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMinnesotaTest()
        {
            var data = await _docLicenseLookupData.GetMinnesotaSiteLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMississippiTest()
        {
            var data = await _docLicenseLookupData.GetMississippiLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMissouriTest()
        {
            var data = await _docLicenseLookupData.GetMissouriLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetMontanaTest()
        {
            var data = await _docLicenseLookupData.GetMontanaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNebraskaTest()
        {
            var data = await _docLicenseLookupData.GetNebraskaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNevadaTest()
        {
            var data = await _docLicenseLookupData.GetNevadaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNewHampshireTest()
        {
            var data = await _docLicenseLookupData.GetNewHampshireLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNewJerseyTest()
        {
            var data = await _docLicenseLookupData.GetNewJerseyLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNewMexicoTest()
        {
            var data = await _docLicenseLookupData.GetNewMexicoLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNewYorkTest()
        {
            var data = await _docLicenseLookupData.GetNewYorkLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNorthCarolinaTest()
        {
            var data = await _docLicenseLookupData.GetNorthCarolinaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetNorthDakotaTest()
        {
            var data = await _docLicenseLookupData.GetNorthDakotaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetOhioTest()
        {
            var data = await _docLicenseLookupData.GetOhioLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetOklahomaTest()
        {
            var data = await _docLicenseLookupData.GetOklahomaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetOregonTest()
        {
            var data = await _docLicenseLookupData.GetOregonLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetPennsylvaniaTest()
        {
            var data = await _docLicenseLookupData.GetPennsylvaniaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetRhodeIslandTest()
        {
            var data = await _docLicenseLookupData.GetRhodeIslandLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetSouthCarolinaTest()
        {
            var data = await _docLicenseLookupData.GetSouthCarolinaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetSouthDakotaTest()
        {
            var data = await _docLicenseLookupData.GetSouthDakotaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetTennesseeTest()
        {
            var data = await _docLicenseLookupData.GetTennesseeLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetTexasTest()
        {
            var data = await _docLicenseLookupData.GetTexasLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }
        [Fact]
        public async Task GetUtahTest()
        {
            var data = await _docLicenseLookupData.GetUtahLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetVermontTest()
        {
            var data = await _docLicenseLookupData.GetVermontLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetVirginiaTest()
        {
            var data = await _docLicenseLookupData.GetVirginiaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetWashingtonTest()
        {
            var data = await _docLicenseLookupData.GetWashingtonLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetWestVirginiaTest()
        {
            var data = await _docLicenseLookupData.GetWestVirginiaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetWisconsinTest()
        {
            var data = await _docLicenseLookupData.GetWisconsinLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetWyomingTest()
        {
            var data = await _docLicenseLookupData.GetWyomingLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

        [Fact]
        public async Task GetDistrictOfColumbia()
        {
            var data = await _docLicenseLookupData.GetDistrictOfColumbiaLicenseInfo();

            AssertLicenseNumberNotNullOrEmpty(data);
        }

    }
}
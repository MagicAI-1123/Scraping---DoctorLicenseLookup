using Microsoft.AspNetCore.Mvc;

namespace DocLicenseLookupApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LicenseFinderController : Controller
    {
        private readonly ILogger<LicenseFinderController> _logger;

        public LicenseFinderController(ILogger<LicenseFinderController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route("GetAlabama")]
        public async Task<List<LicenseInfo>> GetAlabama(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetAlabamaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetAlaska")]
        public async Task<List<LicenseInfo>> GetAlaska(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetAlaskaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetArizona")]
        public async Task<List<LicenseInfo>> GetArizona(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetArizonaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetArkansas")]
        public async Task<List<LicenseInfo>> GetArkansas(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetArkansasLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetCalifornia")]
        public async Task<List<LicenseInfo>> GetCalifornia(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetCaliforniaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetColorado")]
        public async Task<List<LicenseInfo>> GetColorado(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetColoradoLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetConnecticut")]
        public async Task<List<LicenseInfo>> GetConnecticut(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetConnecticutLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetDelaware")]
        public async Task<List<LicenseInfo>> GetDelaware(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetDelawareLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetFlorida")]
        public async Task<List<LicenseInfo>> GetFlorida(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetFloridaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetGeorgia")]
        public async Task<List<LicenseInfo>> GetGeorgia(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetGeorgiaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetHawaii")]
        public async Task<List<LicenseInfo>> GetHawaii(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetHawaiiLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetIdaho")]
        public async Task<List<LicenseInfo>> GetIdaho(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetIdahoLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetIllinois")]
        public async Task<List<LicenseInfo>> GetIllinois(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetIllinoisLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetIndiana")]
        public async Task<List<LicenseInfo>> GetIndiana(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetIndianaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetIowa")]
        public async Task<List<LicenseInfo>> GetIowa(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetIowaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetKansas")]
        public async Task<List<LicenseInfo>> GetKansas(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetKansasLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetKentucky")]
        public async Task<List<LicenseInfo>> GetKentucky(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetKentuckyLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetLouisiana")]
        public async Task<List<LicenseInfo>> GetLouisiana(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetLouisianaSiteLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMaine")]
        public async Task<List<LicenseInfo>> GetMaine(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMaineSiteLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMaryland")]
        public async Task<List<LicenseInfo>> GetMaryland(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMarylandLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMassachusetts")]
        public async Task<List<LicenseInfo>> GetMassachusetts(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMassachussettsSiteLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMichigan")]
        public async Task<List<LicenseInfo>> GetMichigan(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMichiganSiteLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMinnesota")]
        public async Task<List<LicenseInfo>> GetMinnesota(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMinnesotaSiteLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMississippi")]
        public async Task<List<LicenseInfo>> GetMississippi(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMississippiLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMissouri")]
        public async Task<List<LicenseInfo>> GetMissouri(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMissouriLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetMontana")]
        public async Task<List<LicenseInfo>> GetMontana(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetMontanaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNebraska")]
        public async Task<List<LicenseInfo>> GetNebraska(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNebraskaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNevada")]
        public async Task<List<LicenseInfo>> GetNevada(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNevadaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNewHampshire")]
        public async Task<List<LicenseInfo>> GetNewHampshire(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNewHampshireLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNewJersey")]
        public async Task<List<LicenseInfo>> GetNewJersey(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNewJerseyLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNewMexico")]
        public async Task<List<LicenseInfo>> GetNewMexico(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNewMexicoLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNewYork")]
        public async Task<List<LicenseInfo>> GetNewYork(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNewYorkLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNorthCarolina")]
        public async Task<List<LicenseInfo>> GetNorthCarolina(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNorthCarolinaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetNorthDakota")]
        public async Task<List<LicenseInfo>> GetNorthDakota(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetNorthDakotaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetOhio")]
        public async Task<List<LicenseInfo>> GetOhio(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetOhioLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetOklahoma")]
        public async Task<List<LicenseInfo>> GetOklahoma(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetOklahomaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetOregon")]
        public async Task<List<LicenseInfo>> GetOregon(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetOregonLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetPennsylvania")]
        public async Task<List<LicenseInfo>> GetPennsylvania(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetPennsylvaniaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetRhodeIsland")]
        public async Task<List<LicenseInfo>> GetRhodeIsland(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetRhodeIslandLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetSouthCarolina")]
        public async Task<List<LicenseInfo>> GetSouthCarolina(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetSouthCarolinaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetSouthDakota")]
        public async Task<List<LicenseInfo>> GetSouthDakota(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetSouthDakotaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetTennessee")]
        public async Task<List<LicenseInfo>> GetTennessee(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetTennesseeLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetTexas")]
        public async Task<List<LicenseInfo>> GetTexas(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetTexasLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetUtah")]
        public async Task<List<LicenseInfo>> GetUtah(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetUtahLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetVermont")]
        public async Task<List<LicenseInfo>> GetVermont(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetVermontLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetVirginia")]
        public async Task<List<LicenseInfo>> GetVirginia(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetVirginiaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetWashington")]
        public async Task<List<LicenseInfo>> GetWashington(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetWashingtonLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetWestVirginia")]
        public async Task<List<LicenseInfo>> GetWestVirginia(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetWestVirginiaLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetWisconsin")]
        public async Task<List<LicenseInfo>> GetWisconsin(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetWisconsinLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetWyoming")]
        public async Task<List<LicenseInfo>> GetWyoming(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetWyomingLicenseInfo()).ToList();
            return licenseInfoList;
        }

        [HttpGet]
        [Route("GetDistrictOfColumbia")]
        public async Task<List<LicenseInfo>> GetDistrictOfColumbia(string lastName, string firstName = "", bool isDOSearch = false)
        {
            var data = new DocLicenseLookupData(lastName, firstName, isDOSearch);
            var licenseInfoList = (await data.GetDistrictOfColumbiaLicenseInfo()).ToList();
            return licenseInfoList;
        }

    }
}
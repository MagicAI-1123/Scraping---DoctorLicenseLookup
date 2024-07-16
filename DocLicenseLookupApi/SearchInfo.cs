using PuppeteerSharp;

namespace DocLicenseLookupApi
{


    public class SearchInfo
    {
        public IPage Page { get; set; }
        public IBrowser Browser { get; set; }
        public string Url { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastNameSelector { get; set; }
        public string FirstNameSelector { get; set; }
        public string LicenseNumberSelector { get; set; }
        public string LicenseStatusSelector { get; set; }
        public string ProviderNameSelector { get; set; }
        public string LicenseExpirationSelector { get; set; }
        public string SearchButtonSelector { get; set; }
        public string DropdownSelector { get; set; }
        public string DropdownSelectValue { get; set; }
        public string RadioSelector { get; set; }
        public string SecondSearchButtonSelector { get; set; }
        public string StateName { get; set; }
        public string AcceptUsageTermsBtnSelector { get; set; }
        public string IsActiveLicenseSelector { get; set; }
        public string UniqueResultsSelector { get; set; }
        public bool IsDOSearch { get; set; }
        public string SearchTypeInitDropdownSelector { get; set; }
        public string SearchTypeInitDropdownValue { get; set; }
        public bool IsSearchButtonHidden { get; set; }
        public string InitComboBoxSelector { get; set; }
        public string InitComboBoxValue { get; set; }
        public string InitStartButtonSelector { get; set; }
        public string InitComboBox2Selector { get; set; }
        public string InitComboBox2Value { get; set; }

        public string SecondSelectDropdown { get; set; }
        public string SecondSelectValue { get; set; }
        public bool OpensInNewTab { get; set; }
        public bool HasRecaptcha2 { get; set; }
        public string SiteKey { get; set; }
        public string RecaptchaCallback { get; set; }
        public bool HasImageRecaptcha { get; set; }
        public string CaptchaAnswerSelector { get; set; }
        public bool HasRecaptcha3 { get; set; }
        public bool IsRecaptchaAfterSearchBtnClick { get; set; }
        public string ActionName { get; set; }

        public bool HasInitRecaptcha2 { get; set; }
        public bool HasInitModal { get; set; }
        public string AcceptTermsAndConditionsCheckboxSelector { get; set; }

        public bool HasPostSearchBtnRecaptcha2 { get; set; }

        public string PostSearchBtnRecaptcha2ContinueButton { get; set; }
        public string CustomReptchaResponseId { get; set; }
        public string NoRecordsSelector { get; set; }

        public bool IsTable { get; set; }
        public string CustomRecaptchaClickSelector { get; set; }


    }

}

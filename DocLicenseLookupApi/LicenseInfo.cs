using System.Collections.Concurrent;

namespace DocLicenseLookupApi
{

    public class ResponseWrapper
    {
        public int ExecutionTime { get; set;}
        public List<LicenseInfo> LicenseInfo { get; set; } = new();
    }
    public class LicenseInfo
    {
        public string State { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseStatus { get; set; }
        public string LicenseExpiration { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowRetryButton { get; set; }

    }
}

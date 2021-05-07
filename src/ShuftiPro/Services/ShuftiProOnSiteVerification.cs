using Newtonsoft.Json;
using ShuftiPro.Services.Address;
using ShuftiPro.Services.Base;
using ShuftiPro.Services.Document;
using ShuftiPro.Services.Face;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteVerification : ShuftiProOnSiteVerificationBase
    {
        [JsonProperty("face", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProOnSiteFace Face { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProOnSiteAddress Address { get; set; }

        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProOnSiteDocument Document { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOffSiteDocumentVerification : ShuftiProVerificationBase
    {
        [JsonProperty("document")]
        public ShuftiProOffSiteDocument Document { get; set; }
    }
}

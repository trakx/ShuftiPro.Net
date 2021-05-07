using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Document
{
    public class ShuftiProOffSiteDocumentVerification : ShuftiProVerificationBase
    {
        [JsonProperty("document")]
        public ShuftiProOffSiteDocument Document { get; set; }
    }
}

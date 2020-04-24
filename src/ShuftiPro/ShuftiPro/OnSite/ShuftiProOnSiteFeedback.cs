using Newtonsoft.Json;
using ShuftiPro.Base;

namespace ShuftiPro.OnSite
{
    public class ShuftiProOnSiteFeedback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }
    }
}

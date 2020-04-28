using Newtonsoft.Json;
using ShuftiPro.Base;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteFeedback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }
    }
}

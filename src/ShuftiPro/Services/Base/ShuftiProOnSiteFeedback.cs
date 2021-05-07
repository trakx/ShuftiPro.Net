using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProOnSiteFeedback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProCallback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }

        [JsonProperty("verification_data")]
        public ShuftiProVerificationData VerificationData { get; set; }

        [JsonProperty("verification_result")]
        public ShuftiProVerificationResult VerificationResult { get; set; }
    }
}

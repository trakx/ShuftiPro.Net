using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProCallback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }

        [JsonProperty("declined_reason")]
        public string DeclinedReason { get; set; }

        [JsonProperty("declined_codes")]
        public string[] DeclinedCodes { get; set; }

        [JsonProperty("verification_data")]
        public ShuftiProVerificationData VerificationData { get; set; }

        [JsonProperty("verification_result")]
        public ShuftiProVerificationResult VerificationResult { get; set; }

    }
}

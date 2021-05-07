using Newtonsoft.Json;
using ShuftiPro.Models;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProOffSiteFeedback : ShuftiProFeedbackBase
    {
        [JsonProperty("verification_data")]
        public ShuftiProVerificationData Data { get; set; }

        [JsonProperty("verification_result")]
        public ShuftiProVerificationResult Result { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public abstract class ShuftiProOnSiteVerificationBase : ShuftiProVerificationBase
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOnline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowRetry { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_consent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowConsent { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_privacy_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPrivacyPolicy { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_feedback_form", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFeedbackForm { get; set; }
    }
}

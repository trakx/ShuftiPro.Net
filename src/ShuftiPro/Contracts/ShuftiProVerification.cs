using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProVerification
    {
        /// <summary>
        /// Client side reference
        /// </summary>
        [Required]
        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("reference", Required = Required.Always)]
        public string Reference { get; set; }

        /// <summary>
        /// Used to get updated verification status
        /// </summary>
        [Required]
        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("callback_url", Required = Required.Always)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Used for redirection after vendor-side verification
        /// </summary>
        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Enforce country verification. Country code must be a valid ISO 3166-1 alpha-2 country code
        /// </summary>
        [StringLength(2, MinimumLength = 2)]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Language to appear on the verification screens
        /// </summary>
        [StringLength(2, MinimumLength = 2)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// Email of end-user
        /// </summary>
        [StringLength(128, MinimumLength = 6)]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("verification_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProVerificationMode? VerificationMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_results", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("decline_on_single_step", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeclineOnSingleStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// Numeric value for minutes that you want the verification url to remain active.
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeToLive { get; set; }
    }
}

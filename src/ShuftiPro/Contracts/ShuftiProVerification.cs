using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProVerification : IShuftiProReference
    {
        /// <summary>
        /// Client side reference
        /// </summary>
        [Required]
        [StringLength(250, MinimumLength = 6)]
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
        /// Types of proof that can be used for verification
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
        /// Decline the entire verification request when any one of the verification steps fails
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("decline_on_single_step", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeclineOnSingleStep { get; set; }

        /// <summary>
        /// Allow users to upload images or videos in case of non-availability of a functional webcam
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOffline { get; set; }

        /// <summary>
        /// Allow users to capture image or videos in real-time when internet is available
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOnline { get; set; }

        /// <summary>
        /// End-user will be able to retry if verification request is declined by AI
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_consent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowConsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_privacy_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPrivacyPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_feedback_form", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFeedbackForm { get; set; }

        /// <summary>
        /// Numeric value for minutes that you want the verification url to remain active.
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeToLive { get; set; }

        /// <summary>
        /// Field corresponds to Face Verification service
        /// </summary>
        [JsonProperty("face", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProFace Face { get; set; }

        /// <summary>
        /// Field corresponds to Address Verification service
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProAddress Address { get; set; }

        /// <summary>
        /// Field corresponds to Document Verification service
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProDocument Document { get; set; }

        /// <summary>
        /// Field corresponds to Second Document Verification service
        /// </summary>
        [JsonProperty("document_two", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProDocument DocumentTwo { get; set; }

        /// <summary>
        /// Field corresponds to Background Check Verification service
        /// </summary>
        [JsonProperty("background_checks", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProBackgroundCheck BackgroundCheck { get; set; }

        /// <summary>
        /// Field corresponds to Consent Check Verification service
        /// </summary>
        [JsonProperty("consent", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProConsent Consent { get; set; }
    }
}

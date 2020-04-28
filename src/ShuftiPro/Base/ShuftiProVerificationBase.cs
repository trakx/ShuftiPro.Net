using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Base
{
    public class ShuftiProVerificationBase
    {
        [Required]
        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("reference", Required = Required.Always)]
        public string Reference { get; set; }

        [StringLength(2, MinimumLength = 2)]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [StringLength(2, MinimumLength = 2)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [StringLength(128, MinimumLength = 6)]
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("callback_url", Required = Required.Always)]
        public string CallbackUrl { get; set; }

        [StringLength(250, MinimumLength = 6)]
        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        [JsonProperty("verification_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProVerificationMode? VerificationMode { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("show_results", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowResults { get; set; }
    }
}

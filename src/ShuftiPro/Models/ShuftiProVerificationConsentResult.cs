using Newtonsoft.Json;

namespace ShuftiPro.Models
{
    public class ShuftiProVerificationConsentResult
    {
        [JsonProperty("consent")]
        public bool? Consent { get; set; }

        [JsonProperty("selected_type")]
        public bool? SelectedType { get; set; }
    }
}

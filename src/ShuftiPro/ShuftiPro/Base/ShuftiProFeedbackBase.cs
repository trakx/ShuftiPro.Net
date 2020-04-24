using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProFeedbackBase
    {
        [JsonProperty("reference", Required = Required.Always)]
        public string Reference { get; set; }

        [JsonProperty("event", Required = Required.Always)]
        public string Event { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("error")]
        public ShuftiProFeedbackError Error { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProFeedbackError
    {
        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

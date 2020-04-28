using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteFace
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOnline { get; set; }
    }
}

using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Document
{
    public class ShuftiProOnSiteDocument : ShuftiProDocument
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowOnline { get; set; }
    }
}

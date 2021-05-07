using Newtonsoft.Json;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProAmlData
    {
        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Filters { get; set; }

        [JsonProperty("hits", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProHit[] Hits { get; set; }
    }
}

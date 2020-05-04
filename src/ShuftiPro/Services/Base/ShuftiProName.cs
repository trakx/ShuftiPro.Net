using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProName : ShuftiProNameData
    {
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [JsonProperty("fuzzy_match", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool FuzzyMatch { get; set; }
    }
}

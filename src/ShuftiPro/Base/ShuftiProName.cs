using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProName
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("middle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [JsonProperty("fuzzy_match", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool FuzzyMatch { get; set; }
    }
}

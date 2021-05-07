using System;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProSourceNote
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("aml_types")]
        public ShuftiProAmlType[] AmlTypes { get; set; }

        [JsonProperty("country_codes")]
        public string[] CountryCodes { get; set; }

        [JsonProperty("listing_started_utc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ListingStarted { get; set; }

        [JsonProperty("listing_ended_utc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ListingEnded { get; set; }
    }
}

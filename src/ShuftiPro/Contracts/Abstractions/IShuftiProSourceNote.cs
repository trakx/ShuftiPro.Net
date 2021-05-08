using System;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProSourceNote
    {
        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("url")]
        string Url { get; set; }

        [JsonProperty("aml_types")]
        ShuftiProAmlType[] AmlTypes { get; set; }

        [JsonProperty("country_codes")]
        string[] CountryCodes { get; set; }

        [JsonProperty("listing_started_utc", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? ListingStarted { get; set; }

        [JsonProperty("listing_ended_utc", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? ListingEnded { get; set; }
    }
}

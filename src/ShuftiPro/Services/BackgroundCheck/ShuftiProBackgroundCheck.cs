using System;
using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProBackgroundCheck
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProName Name { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DayOfBirth { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("ongoing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnGoing { get; set; }
    }
}

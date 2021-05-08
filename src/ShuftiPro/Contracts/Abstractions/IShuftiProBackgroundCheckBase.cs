using System;
using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProBackgroundCheckBase
    {
        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? DayOfBirth { get; set; }
    }
}

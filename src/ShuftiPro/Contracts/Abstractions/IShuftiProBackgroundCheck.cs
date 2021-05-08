using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProBackgroundCheck : IShuftiProBackgroundCheckBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProName Name { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("ongoing", NullValueHandling = NullValueHandling.Ignore)]
        bool? OnGoing { get; set; }
    }
}
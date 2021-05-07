using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackBase
    {
        [JsonProperty("reference", Required = Required.Always)]
        string Reference { get; set; }

        [JsonProperty("event", Required = Required.Always)]
        ShuftiProEvent Event { get; set; }

        [JsonProperty("country")]
        string Country { get; set; }

        [JsonProperty("verification_result", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProFeedbackResult Result { get; set; }
    }
}

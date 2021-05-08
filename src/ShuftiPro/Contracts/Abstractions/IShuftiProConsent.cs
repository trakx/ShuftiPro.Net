using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProConsent : IShuftiProProof, IShuftiProConsentBase
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("with_face", DefaultValueHandling = DefaultValueHandling.Ignore)]
        bool? WithFace { get; set; }
    }
}

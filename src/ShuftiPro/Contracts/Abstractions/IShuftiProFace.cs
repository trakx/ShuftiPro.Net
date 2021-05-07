using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFace
    {
        [JsonConverter(typeof(ShuftiProByteArrayToBase64Converter))]
        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        byte[] Proof { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOnline { get; set; }
    }
}
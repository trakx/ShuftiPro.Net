using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProVerificationInstruction
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_paper_based", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowPaperBased { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_photocopy", NullValueHandling = NullValueHandling.Ignore)]

        bool? AllowPhotocopy { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_laminated", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowLaminated { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_screenshot", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowScreenshot { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_cropped", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowCropped { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_scanned", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowScanned { get; set; }

    }
}

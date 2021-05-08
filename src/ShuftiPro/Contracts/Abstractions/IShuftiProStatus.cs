using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProStatus : IShuftiProFeedbackBase
    {
        [JsonProperty("proofs"), JsonConverter(typeof(ShuftiProEmptyArrayToObjectConverter))]
        ShuftiProProofData Proofs { get; set; }

        [JsonProperty("additional_data")]
        ShuftiProAdditionalData AdditionalData { get; set; }
    }
}

using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services
{
    public class ShuftiProStatus
    {
        [JsonProperty("reference", Required = Required.Always)]
        public string Reference { get; set; }

        [JsonProperty("event", Required = Required.Always)]
        public ShuftiProEvent Event { get; set; }

        [JsonProperty("proofs"), JsonConverter(typeof(ShuftiProEmptyArrayToObjectConverter))]
        public ShuftiProProofData Proofs { get; set; }

        [JsonProperty("verification_data"), JsonConverter(typeof(ShuftiProEmptyArrayToObjectConverter))]
        public ShuftiProVerificationData Data { get; set; }

        [JsonProperty("verification_result")]
        public ShuftiProVerificationResult Result { get; set; }

        [JsonProperty("additional_data")]
        public ShuftiProAdditionalData AdditionalData { get; set; }
    }
}

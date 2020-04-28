using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOffSiteDocument : ShuftiProDocument
    {
        [Required]
        [JsonProperty("proof", Required = Required.Always)]
        public string Proof { get; set; }

        [JsonProperty("additional_proof")]
        public string AdditionalProof { get; set; }
    }
}

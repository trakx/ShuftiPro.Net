using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Base;

namespace ShuftiPro.OffSite
{
    public class ShuftiProOffSiteDocument : ShuftiProDocumentBase
    {
        [Required]
        [JsonProperty("proof", Required = Required.Always)]
        public string Proof { get; set; }

        [JsonProperty("additional_proof")]
        public string AdditionalProof { get; set; }
    }
}

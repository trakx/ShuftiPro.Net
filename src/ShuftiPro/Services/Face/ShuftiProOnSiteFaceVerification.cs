using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Base;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteFaceVerification : ShuftiProVerificationBase
    {
        [Required]
        [JsonProperty("document", Required = Required.Always)]
        public ShuftiProOnSiteFace Face { get; set; }
    }
}

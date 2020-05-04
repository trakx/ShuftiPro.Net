using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteFaceVerification : ShuftiProVerificationBase
    {
        [Required]
        [JsonProperty("face", Required = Required.Always)]
        public ShuftiProOnSiteFace Face { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Face
{
    public class ShuftiProOnSiteFaceVerification : ShuftiProVerificationBase
    {
        [Required]
        [JsonProperty("face", Required = Required.Always)]
        public ShuftiProOnSiteFace Face { get; set; }
    }
}

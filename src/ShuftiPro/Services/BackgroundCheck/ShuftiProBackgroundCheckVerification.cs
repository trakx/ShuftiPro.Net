using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProBackgroundCheckVerification : ShuftiProVerificationBase
    {
        [Required]
        [JsonProperty("background_checks", Required = Required.Always)]
        public ShuftiProBackgroundCheck Check { get; set; }
    }
}

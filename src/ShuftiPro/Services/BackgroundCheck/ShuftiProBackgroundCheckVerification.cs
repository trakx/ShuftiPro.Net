using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProBackgroundCheckVerification : ShuftiProVerificationBase
    {
        [Required]
        [JsonProperty("background_checks", Required = Required.Always)]
        public ShuftiProBackgroundCheck Check { get; set; }
    }
}

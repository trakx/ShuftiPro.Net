using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteAddressVerification : ShuftiProOnSiteVerificationBase
    {
        [Required]
        [JsonProperty("address", Required = Required.Always)]
        public ShuftiProOnSiteAddress Address { get; set; }
    }
}

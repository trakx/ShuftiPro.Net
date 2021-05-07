using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Address
{
    public class ShuftiProOnSiteAddressVerification : ShuftiProOnSiteVerificationBase
    {
        [Required]
        [JsonProperty("address", Required = Required.Always)]
        public ShuftiProOnSiteAddress Address { get; set; }
    }
}

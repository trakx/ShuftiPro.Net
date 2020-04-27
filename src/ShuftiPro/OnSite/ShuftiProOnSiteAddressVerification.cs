using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.OnSite
{
    public class ShuftiProOnSiteAddressVerification : ShuftiProOnSiteVerification
    {
        [Required]
        [JsonProperty("address", Required = Required.Always)]
        public ShuftiProOnSiteAddress Address { get; set; }
    }
}

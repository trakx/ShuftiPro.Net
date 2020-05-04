using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProOnSiteDocumentVerification : ShuftiProOnSiteVerification
    {
        [Required]
        [JsonProperty("document", Required = Required.Always)]
        public ShuftiProOnSiteDocument Document { get; set; }
    }
}

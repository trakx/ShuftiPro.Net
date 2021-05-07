using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Services.Document
{
    public class ShuftiProOnSiteDocumentVerification : ShuftiProOnSiteVerificationBase
    {
        [Required]
        [JsonProperty("document", Required = Required.Always)]
        public ShuftiProOnSiteDocument Document { get; set; }
    }
}

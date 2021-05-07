using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProReference
    {
        [Required, StringLength(250, MinimumLength = 6)]
        [JsonProperty("reference", Required = Required.Always)]
        public string Reference { get; set; }
    }
}

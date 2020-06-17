using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services
{
    public class ShuftiProDocumentData : ShuftiProDocumentBase
    {
        [JsonProperty("selected_type")]
        public ShuftiProDocumentType[] SelectedType { get; set; }

        [JsonProperty("supported_types", Required = Required.Always)]
        public ShuftiProDocumentType[] SupportedTypes { get; set; }
    }
}

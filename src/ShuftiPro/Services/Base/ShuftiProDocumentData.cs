using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services
{
    public class ShuftiProDocumentData : ShuftiProDocumentBase
    {
        [JsonProperty("selected_type")]
        public ShuftiProDocumentType[] SelectedType { get; set; }
    }
}

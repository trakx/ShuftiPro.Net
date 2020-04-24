using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Base
{
    public class ShuftiProDocumentInfo : ShuftiProDocumentBase
    {
        [JsonProperty("selected_type")]
        public DocumentType[] SelectedType { get; set; }
    }
}

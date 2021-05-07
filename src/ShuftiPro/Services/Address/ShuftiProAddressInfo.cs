using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services.Address
{
    public class ShuftiProAddressInfo : ShuftiProAddressBase
    {
        [JsonProperty("selected_type")]
        public ShuftiProDocumentType[] SelectedType { get; set; }
    }
}

using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProVerificationResultBase
    {
        [JsonProperty("Address")]
        public ShuftiProAddressResult Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentResult Document { get; set; }
    }
}

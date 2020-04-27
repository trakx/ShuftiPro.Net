using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProVerificationResultBase
    {
        [JsonProperty("Address")]
        public ShuftiProAddressResult Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentResult Document { get; set; }
    }
}

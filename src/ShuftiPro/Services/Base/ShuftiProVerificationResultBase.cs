using Newtonsoft.Json;
using ShuftiPro.Services.Address;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProVerificationResultBase
    {
        [JsonProperty("Address")]
        public ShuftiProAddressResult Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentResult Document { get; set; }
    }
}

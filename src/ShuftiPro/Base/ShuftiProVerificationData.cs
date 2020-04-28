using Newtonsoft.Json;
using ShuftiPro.Services;

namespace ShuftiPro.Base
{
    public class ShuftiProVerificationData
    {
        [JsonProperty("address")]
        public ShuftiProAddressInfo Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentData Document { get; set; }
    }
}

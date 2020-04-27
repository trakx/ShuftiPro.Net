using Newtonsoft.Json;

namespace ShuftiPro.Base
{
    public class ShuftiProVerificationData
    {
        [JsonProperty("address")]
        public ShuftiProAddressInfo Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentInfo Document { get; set; }
    }
}

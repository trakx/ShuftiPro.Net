using Newtonsoft.Json;
using ShuftiPro.Services.Address;
using ShuftiPro.Services.BackgroundCheck;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProVerificationData
    {
        [JsonProperty("address")]
        public ShuftiProAddressInfo Address { get; set; }

        [JsonProperty("document")]
        public ShuftiProDocumentData Document { get; set; }

        [JsonProperty("background_checks")]
        public ShuftiProBackgroundCheckData BackgroundCheck { get; set; }
    }
}

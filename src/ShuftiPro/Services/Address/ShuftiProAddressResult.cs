using Newtonsoft.Json;

namespace ShuftiPro.Services.Address
{
    public class ShuftiProAddressResult
    {
        [JsonProperty("name")]
        public bool? Name { get; set; }

        [JsonProperty("full_address")]
        public bool? FullAddress { get; set; }
    }
}

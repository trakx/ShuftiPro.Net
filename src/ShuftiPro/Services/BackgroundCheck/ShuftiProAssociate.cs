using Newtonsoft.Json;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProAssociate
    {
        [JsonProperty("association")]
        public string Association { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

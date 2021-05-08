using Newtonsoft.Json;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProField : IShuftiProField
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}

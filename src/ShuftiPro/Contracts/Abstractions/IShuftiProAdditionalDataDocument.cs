using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAdditionalDataDocument
    {
        [JsonProperty("proof")]
        Dictionary<string, string> Proof { get; set; }
    }
}

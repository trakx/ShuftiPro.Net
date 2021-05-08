using System;
using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProMedia
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? Date { get; set; }

        [JsonProperty("snippet")]
        string Snippet { get; set; }

        [JsonProperty("title")]
        string Title { get; set; }

        [JsonProperty("url")]
        string Url { get; set; }
    }
}

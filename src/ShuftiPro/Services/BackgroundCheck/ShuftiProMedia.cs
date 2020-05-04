using System;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProMedia
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

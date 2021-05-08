using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackError
    {
        [JsonProperty("service")]
        string Service { get; set; }

        [JsonProperty("key")]
        string Key { get; set; }

        [JsonProperty("message")]
        string Message { get; set; }
    }
}

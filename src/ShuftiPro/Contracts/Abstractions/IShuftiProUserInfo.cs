using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProUserInfo
    {
        [JsonProperty("agent")]
        ShuftiProUserAgent Agent { get; set; }

        [JsonProperty("geolocation")]
        ShuftiProUserGeolocation Geolocation { get; set; }
    }
}

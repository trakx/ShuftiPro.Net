using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProUserAgent
    {
        [JsonProperty("browser_name")]
        string BrowserName { get; set; }

        [JsonProperty("device_name")]
        string DeviceName { get; set; }

        [JsonProperty("platform_name")]
        string PlatformName { get; set; }

        [JsonProperty("useragent")]
        string UserAgent { get; set; }

        [JsonProperty("is_desktop")]
        bool IsDesktop { get; set; }

        [JsonProperty("is_phone")]
        bool IsPhone { get; set; }
    }
}

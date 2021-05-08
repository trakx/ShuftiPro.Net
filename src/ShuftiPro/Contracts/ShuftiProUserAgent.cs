using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProUserAgent : IShuftiProUserAgent
    {
        public string BrowserName { get; set; }

        public string DeviceName { get; set; }

        public string PlatformName { get; set; }

        public string UserAgent { get; set; }

        public bool IsDesktop { get; set; }

        public bool IsPhone { get; set; }
    }
}

using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProUserInfo : IShuftiProUserInfo
    {
        public ShuftiProUserAgent Agent { get; set; }

        public ShuftiProUserGeolocation Geolocation { get; set; }
    }
}

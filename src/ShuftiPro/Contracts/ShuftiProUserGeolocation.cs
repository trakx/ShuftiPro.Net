using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProUserGeolocation : IShuftiProUserGeolocation
    {
        public string AutonomousSystemNumber { get; set; }

        public string Capital { get; set; }

        public string City { get; set; }

        public string ContinentCode { get; set; }

        public string ContinentName { get; set; }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }

        public string RegionCode { get; set; }

        public string RegionName { get; set; }

        public string Currency { get; set; }

        public string Timezone { get; set; }

        public string Host { get; set; }

        public string Ip { get; set; }

        public string IpType { get; set; }

        public string InternetServiceProvider { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string MetroCode { get; set; }

        public string PostalCode { get; set; }

        public string ReverseDNS { get; set; }
    }
}

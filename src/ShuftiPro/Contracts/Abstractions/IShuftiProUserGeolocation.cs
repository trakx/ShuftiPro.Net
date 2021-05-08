using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProUserGeolocation
    {
        [JsonProperty("asn")]
        string AutonomousSystemNumber { get; set; }

        [JsonProperty("capital")]
        string Capital { get; set; }

        [JsonProperty("city")]
        string City { get; set; }

        [JsonProperty("continent_code")]
        string ContinentCode { get; set; }

        [JsonProperty("continent_name")]
        string ContinentName { get; set; }

        [JsonProperty("country_code")]
        string CountryCode { get; set; }

        [JsonProperty("country_name")]
        string CountryName { get; set; }

        [JsonProperty("region_code")]
        string RegionCode { get; set; }

        [JsonProperty("region_name")]
        string RegionName { get; set; }

        [JsonProperty("currency")]
        string Currency { get; set; }

        [JsonProperty("timezone")]
        string Timezone { get; set; }

        [JsonProperty("host")]
        string Host { get; set; }

        [JsonProperty("ip")]
        string Ip { get; set; }

        [JsonProperty("ip_type")]
        string IpType { get; set; }

        [JsonProperty("isp")]
        string InternetServiceProvider { get; set; }

        [JsonProperty("latitude")]
        string Latitude { get; set; }

        [JsonProperty("longitude")]
        string Longitude { get; set; }

        [JsonProperty("metro_code")]
        string MetroCode { get; set; }

        [JsonProperty("postal_code")]
        string PostalCode { get; set; }

        [JsonProperty("rdns")]
        string ReverseDNS { get; set; }
    }
}

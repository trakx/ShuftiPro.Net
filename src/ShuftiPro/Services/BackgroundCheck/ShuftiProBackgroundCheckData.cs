using System;
using Newtonsoft.Json;

namespace ShuftiPro.Services
{
    public class ShuftiProBackgroundCheckData
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProNameData Name { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DayOfBirth { get; set; }

        [JsonProperty("aml_data", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProAmlData AmlData { get; set; }
    }
}

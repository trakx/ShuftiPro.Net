﻿using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFace : IShuftiProProof
    {
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOnline { get; set; }
        
        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("check_duplicate_request", NullValueHandling = NullValueHandling.Ignore)]
        bool? CheckDuplicateRequest { get; set; }
    }
}
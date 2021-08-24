﻿using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProNameBase
    {

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        string FirstName { get; set; }

        [JsonProperty("middle_name", NullValueHandling = NullValueHandling.Ignore)]
        string MiddleName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        string LastName { get; set; }

        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        string FullName { get; }

    }
}

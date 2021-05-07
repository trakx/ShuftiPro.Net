using System.Collections.Generic;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services.BackgroundCheck
{
    public class ShuftiProHit
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity_type")]
        public ShuftiProHitEntityType EntityType { get; set; }

        [JsonProperty("score")]
        public float Score { get; set; }

        [JsonProperty("match_types")]
        public string[] MatchTypes { get; set; }

        [JsonProperty("alternative_names")]
        public string[] AlternativeNames { get; set; }

        [JsonProperty("assets")]
        public ShuftiProAsset[] Assets { get; set; }

        [JsonProperty("associates")]
        public ShuftiProAssociate[] Associates { get; set; }

        [JsonProperty("fields")]
        public Dictionary<string, ShuftiProField[]> Fields { get; set; }

        [JsonProperty("media")]
        public ShuftiProMedia[] Media { get; set; }

        [JsonProperty("source_notes")]
        public Dictionary<string, ShuftiProSourceNote> SourceNotes { get; set; }

        [JsonProperty("sources")]
        public string[] Sources { get; set; }

        [JsonProperty("types")]
        public ShuftiProAmlType[] Types { get; set; }
    }
}

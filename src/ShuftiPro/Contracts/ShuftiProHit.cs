using System.Collections.Generic;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProHit : IShuftiProHit
    {
        public string Name { get; set; }

        public ShuftiProHitEntityType EntityType { get; set; }

        public float Score { get; set; }

        public string[] MatchTypes { get; set; }

        public string[] AlternativeNames { get; set; }

        public ShuftiProAsset[] Assets { get; set; }

        public ShuftiProAssociate[] Associates { get; set; }

        public Dictionary<string, ShuftiProField[]> Fields { get; set; }

        public ShuftiProMedia[] Media { get; set; }

        public Dictionary<string, ShuftiProSourceNote> SourceNotes { get; set; }

        public string[] Sources { get; set; }

        public ShuftiProAmlType[] Types { get; set; }
    }
}

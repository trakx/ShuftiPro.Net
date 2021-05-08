using System;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProSourceNote : IShuftiProSourceNote
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public ShuftiProAmlType[] AmlTypes { get; set; }

        public string[] CountryCodes { get; set; }

        public DateTime? ListingStarted { get; set; }

        public DateTime? ListingEnded { get; set; }
    }
}

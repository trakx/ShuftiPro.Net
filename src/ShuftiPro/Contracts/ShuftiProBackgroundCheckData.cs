using System;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProBackgroundCheckData : IShuftiProBackgroundCheckData
    {
        public ShuftiProNameData Name { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public ShuftiProAmlData AmlData { get; set; }
    }
}

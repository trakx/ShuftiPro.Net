using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAmlData : IShuftiProAmlData
    {
        public string[] Filters { get; set; }

        public ShuftiProHit[] Hits { get; set; }
    }
}

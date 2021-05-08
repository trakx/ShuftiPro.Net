using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAsset : IShuftiProAsset
    {
        public string Url { get; set; }

        public string Source { get; set; }

        public string Type { get; set; }
    }
}

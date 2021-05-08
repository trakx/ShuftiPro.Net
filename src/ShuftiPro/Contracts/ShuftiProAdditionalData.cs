using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAdditionalData : IShuftiProAdditionalData
    {
        public ShuftiProAdditionalDataDocument Document { get; set; }
    }
}

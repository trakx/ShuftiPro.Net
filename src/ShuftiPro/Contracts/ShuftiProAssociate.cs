using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAssociate : IShuftiProAssociate
    {
        public string Association { get; set; }

        public string Name { get; set; }
    }
}

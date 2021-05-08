using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProDocumentProof : IShuftiProDocumentProof
    {
        public string Proof { get; set; }

        public string AdditionalProof { get; set; }
    }
}

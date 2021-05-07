using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProVerificationInstruction : IShuftiProVerificationInstruction
    {
        public bool? AllowPaperBased { get; set; }

        public bool? AllowPhotocopy { get; set; }

        public bool? AllowLaminated { get; set; }
    }
}

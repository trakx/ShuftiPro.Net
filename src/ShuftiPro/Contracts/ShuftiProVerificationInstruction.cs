using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProVerificationInstruction : IShuftiProVerificationInstruction
    {
        public bool? AllowPaperBased { get; set; }

        public bool? AllowPhotocopy { get; set; }

        public bool? AllowLaminated { get; set; }

        public bool? AllowScreenshot { get; set; }

        public bool? AllowCropped { get; set; }

        public bool? AllowScanned { get; set; }
    }
}

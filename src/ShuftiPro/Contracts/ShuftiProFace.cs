using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFace : IShuftiProFace
    {
        public byte[] Proof { get; set; }

        public bool? AllowOffline { get; set; }

        public bool? AllowOnline { get; set; }
    }
}

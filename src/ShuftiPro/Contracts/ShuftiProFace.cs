using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFace : IShuftiProFace
    {
        public string Proof { get; set; }

        public bool? AllowOffline { get; set; }

        public bool? AllowOnline { get; set; }
        
        public bool? CheckDuplicateRequest { get; set; }
    }
}

using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProServiceDeclinedCodes : IShuftiProServiceDeclinedCodes
    {
        public string[] Address { get; set; }

        public string[] Document { get; set; }

        public string[] Face { get; set; }

        public string[] Consent { get; set; }
    }
}

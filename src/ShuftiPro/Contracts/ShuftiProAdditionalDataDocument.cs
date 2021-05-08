using System.Collections.Generic;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAdditionalDataDocument : IShuftiProAdditionalDataDocument
    {
        public Dictionary<string, string> Proof { get; set; }
    }
}

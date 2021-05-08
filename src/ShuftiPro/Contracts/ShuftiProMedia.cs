using System;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProMedia : IShuftiProMedia
    {
        public DateTime? Date { get; set; }

        public string Snippet { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}

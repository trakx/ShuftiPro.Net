using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAddress : IShuftiProAddress
    {
        [Required]
        public ShuftiProAddressType[] SupportedTypes { get; set; }

        [JsonConverter(typeof(ShuftiProEmptyNameToObjectConverter))]
        public ShuftiProName Name { get; set; }

        public string FullAddress { get; set; }

        public string Proof { get; set; }

        public string TaxIdentityNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public bool? AddressFuzzyMatch { get; set; }

        public bool? BacksideProofRequired { get; set; }

        public ShuftiProVerificationInstruction Instruction { get; set; }
    }
}

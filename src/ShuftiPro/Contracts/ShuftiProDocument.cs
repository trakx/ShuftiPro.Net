using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProDocument : IShuftiProDocument
    {
        public string Proof { get; set; }

        public string AdditionalProof { get; set; }

        [JsonConverter(typeof(ShuftiProEmptyNameToObjectConverter))]
        public ShuftiProName Name { get; set; }

        public ShuftiProGenderType? Gender { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [Required]
        public ShuftiProDocumentType[] SupportedTypes { get; set; }

        public bool? FetchEnhancedData { get; set; }

        public bool? BacksideProofRequired { get; set; }

        public bool? AllowOffline { get; set; }

        public bool? AllowOnline { get; set; }

        public ShuftiProVerificationInstruction Instruction { get; set; }
    }
}

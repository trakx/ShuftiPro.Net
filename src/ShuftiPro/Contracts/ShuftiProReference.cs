using System.ComponentModel.DataAnnotations;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProReference : IShuftiProReference
    {
        [Required]
        public string Reference { get; set; }
    }
}

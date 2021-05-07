using Newtonsoft.Json;
using ShuftiPro.Services.Base;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedback : IShuftiProFeedbackBase
    {
        [JsonProperty("email")]
        string Email { get; set; }

        [JsonProperty("error")]
        ShuftiProFeedbackError Error { get; set; }

        [JsonProperty("verification_url")]
        string VerificationUrl { get; set; }
    }
}

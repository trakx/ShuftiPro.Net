using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedback : IShuftiProFeedbackBase
    {
        [JsonProperty("email")]
        string Email { get; set; }

        [JsonProperty("verification_url", NullValueHandling = NullValueHandling.Ignore)]
        string VerificationUrl { get; set; }
    }
}

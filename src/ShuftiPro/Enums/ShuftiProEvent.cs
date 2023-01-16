using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProEvent
    {
        [EnumMember(Value = "request.pending")]
        RequestPending,

        [EnumMember(Value = "request.invalid")]
        RequestInvalid,

        [EnumMember(Value = "request.timeout")]
        RequestTimeout,

        [EnumMember(Value = "request.unauthorized")]
        RequestUnauthorized,

        [EnumMember(Value = "request.deleted")]
        RequestDeleted,

        [EnumMember(Value = "request.received")]
        RequestReceived,

        [EnumMember(Value = "verification.accepted")]
        VerificationAccepted,

        [EnumMember(Value = "verification.declined")]
        VerificationDeclined,

        [EnumMember(Value = "verification.cancelled")]
        VerificationCancelled,

        [EnumMember(Value = "verification.status.changed")]
        VerificationStatusChanged,
        
        [EnumMember(Value = "review.pending")]
        ReviewPending,
    }
}

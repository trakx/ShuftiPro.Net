using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProConsentType
    {
        [EnumMember(Value = "handwritten")]
        Handwritten,

        [EnumMember(Value = "printed")]
        Printed,
    }
}

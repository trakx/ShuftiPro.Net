using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProGenderType
    {
        [EnumMember(Value = "M")]
        Male,

        [EnumMember(Value = "F")]
        Female,

        [EnumMember(Value = "O")]
        Others,
    }
}

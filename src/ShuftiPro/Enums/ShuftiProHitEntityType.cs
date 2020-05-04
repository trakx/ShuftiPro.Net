using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProHitEntityType
    {
        [EnumMember(Value = "person")]
        Person,

        [EnumMember(Value = "organisation")]
        Organisation
    }
}

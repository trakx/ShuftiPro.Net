using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProMatchType
    {
        [EnumMember(Value = "equivalent_name")]
        EquivalentName,

        [EnumMember(Value = "year_of_birth")]
        YearOrBirth,

        [EnumMember(Value = "aka_exact")]
        AkaExact,

        [EnumMember(Value = "equivalent_aka")]
        EquivalentAka
    }
}

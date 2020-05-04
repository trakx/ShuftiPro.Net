using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProAmlType
    {
        [EnumMember(Value = "warning")]
        Warning,

        [EnumMember(Value = "sanction")]
        Sanction,

        [EnumMember(Value = "pep")]
        Pep,

        [EnumMember(Value = "pep-class-1")]
        PepClass1,

        [EnumMember(Value = "pep-class-2")]
        PepClass2,

        [EnumMember(Value = "pep-class-3")]
        PepClass3,

        [EnumMember(Value = "pep-class-4")]
        PepClass4,

        [EnumMember(Value = "adverse-media")]
        AdverseMedia,

        [EnumMember(Value = "adverse-media-financial-crime")]
        AdverseMediaFinancialCrime,

        [EnumMember(Value = "adverse-media-fraud")]
        AdverseMediaFraud,

        [EnumMember(Value = "adverse-media-general")]
        AdverseMediaGeneral,

        [EnumMember(Value = "adverse-media-narcotics")]
        AdverseMediaNarcotics,

        [EnumMember(Value = "adverse-media-sexual-crime")]
        AdverseMediaSexualCrime,

        [EnumMember(Value = "adverse-media-terrorism")]
        AdverseMediaTerrorism,

        [EnumMember(Value = "adverse-media-violent-crime")]
        AdverseMediaViolentCrime,
    }
}

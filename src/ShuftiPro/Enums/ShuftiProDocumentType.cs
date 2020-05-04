using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProDocumentType
    {
        [EnumMember(Value = "")]
        Undefined,

        [EnumMember(Value = "id_card")]
        IdCard,

        [EnumMember(Value = "passport")]
        Passport,

        [EnumMember(Value = "driving_license")]
        DrivingLicense,

        [EnumMember(Value = "credit_or_debit_card")]
        CreditOrDebitCard
    }
}

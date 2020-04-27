using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressType
    {
        [EnumMember(Value = "id_card")]
        IdCard,

        [EnumMember(Value = "passport")]
        Passport,

        [EnumMember(Value = "driving_license")]
        DrivingLicense,

        [EnumMember(Value = "utility_bill")]
        UtilityBill,

        [EnumMember(Value = "bank_statement")]
        BankStatement,

        [EnumMember(Value = "rent_agreement")]
        RentAgreement,

        [EnumMember(Value = "employer_letter")]
        EmployerLetter,

        [EnumMember(Value = "insurance_agreement")]
        InsuranceAgreement,

        [EnumMember(Value = "tax_bill")]
        TaxBill,
    }
}

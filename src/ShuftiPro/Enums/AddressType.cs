using System.Runtime.Serialization;

namespace ShuftiPro.Enums
{
    public enum AddressType
    {
        [EnumMember(Value = "id_card")]
        IdCard,

        [EnumMember(Value = "bank_statement")]
        BankStatement
    }
}

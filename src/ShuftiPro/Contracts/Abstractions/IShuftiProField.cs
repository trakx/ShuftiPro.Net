namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProField
    {
        string Source { get; set; }

        string Value { get; set; }

        string Tag { get; set; }
    }
}

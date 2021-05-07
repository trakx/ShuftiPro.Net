using Newtonsoft.Json.Converters;

namespace ShuftiPro.Converters
{
    internal class ShuftiProDateTimeConverter : IsoDateTimeConverter
    {
        public ShuftiProDateTimeConverter()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}

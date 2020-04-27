using Newtonsoft.Json.Converters;

namespace ShuftiPro
{
    internal class ShuftiProDateTimeConverter : IsoDateTimeConverter
    {
        public ShuftiProDateTimeConverter()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}

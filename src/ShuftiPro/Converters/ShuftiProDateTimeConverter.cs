using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Converters
{
    internal class ShuftiProDateTimeConverter : IsoDateTimeConverter
    {
        public ShuftiProDateTimeConverter()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (DateTime.MinValue.Equals(value))
            {
                writer.WriteValue(string.Empty);
            }
            else
            {
                base.WriteJson(writer, value, serializer);
            }
        }
    }
}
using System;
using Newtonsoft.Json;
using ShuftiPro.Contracts;

namespace ShuftiPro.Converters
{
    internal class ShuftiProEmptyNameToObjectConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var name = value as ShuftiProName;
            if (name == null || 
                (string.IsNullOrEmpty(name.FirstName) && 
                 string.IsNullOrEmpty(name.LastName) && 
                 string.IsNullOrEmpty(name.MiddleName)))
            {
                writer.WriteValue(string.Empty);
            }
            else
            {
                serializer.Serialize(writer, value);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, objectType);
        }

        public override bool CanConvert(Type objectType) => true;
    }
}

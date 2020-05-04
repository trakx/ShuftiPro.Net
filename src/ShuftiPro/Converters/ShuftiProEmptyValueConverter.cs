using System;
using Newtonsoft.Json;

namespace ShuftiPro
{
    public class ShuftiProEmptyArrayToObjectConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                reader.Read();
                return null;
            }

            return serializer.Deserialize(reader, objectType);
        }

        public override bool CanConvert(Type objectType) => true;
    }
}

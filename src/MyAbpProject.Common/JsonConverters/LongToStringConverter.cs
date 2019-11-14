using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MyAbpProject.Common.JsonConverters
{
    public class LongToStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Int64).Equals(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jt = JToken.ReadFrom(reader);
            return jt.Value<long>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }
    }
}

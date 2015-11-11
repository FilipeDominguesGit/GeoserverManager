using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Converter
{
   public class ListJsonConverter<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
            //throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                var l = new List<T>();
                reader.Read();
                while (reader.TokenType != JsonToken.EndArray)
                {
                    l.Add(serializer.Deserialize<T>(reader));

                    reader.Read();
                }
                return l;
            }
            return new List<T> { serializer.Deserialize<T>(reader) };
        }

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T)) || (objectType == typeof(IEnumerable<T>));
        }
    }
}

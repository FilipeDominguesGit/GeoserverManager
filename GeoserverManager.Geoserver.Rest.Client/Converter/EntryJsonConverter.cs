using System;
using System.Collections.Generic;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Converter
{
    public class EntryJsonConverter : JsonConverter
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
                var l = new List<Entry>();
                reader.Read();
                while (reader.TokenType != JsonToken.EndArray)
                {
                    l.Add(serializer.Deserialize<Entry>(reader));

                    reader.Read();
                }
                return l;
            }
            return new List<Entry> { serializer.Deserialize<Entry>(reader) };
        }

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Entry)) || (objectType == typeof(IEnumerable<Entry>));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Converter
{
    public class GeometryJsonConverter : JsonConverter
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
                var l = new List<Geometry>();
                reader.Read();
                while (reader.TokenType != JsonToken.EndArray)
                {
                    l.Add(serializer.Deserialize<Geometry>(reader));

                    reader.Read();
                }
                return l;
            }
            return new List<Geometry> { serializer.Deserialize<Geometry>(reader) };
        }

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Geometry)) || (objectType == typeof(IEnumerable<Geometry>));
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface IMetadata
    {
       IEnumerable<IEntry> Entry { get; set; }
    }
}
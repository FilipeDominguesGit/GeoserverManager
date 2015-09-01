using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public interface IMetadata
    {
        IEnumerable<IEntry> Entry { get; set; }
    }
}
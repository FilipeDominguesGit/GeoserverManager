using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings
{
    public interface IMetadata
    {
        IEnumerable<IMap> Map { get; set; }
    }
}
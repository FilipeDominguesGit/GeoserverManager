using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface IMetadata
    {
        IEnumerable<IMap> Map { get; set; }
    }
}
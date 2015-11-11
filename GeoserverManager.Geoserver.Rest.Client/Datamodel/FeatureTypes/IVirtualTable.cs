using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface IVirtualTable
    {
        string Name { get; set; }
        string Sql { get; set; }
        string EscapeSql { get; set; }
        IEnumerable<IGeometry> Geometry { get; set; }
    }
}
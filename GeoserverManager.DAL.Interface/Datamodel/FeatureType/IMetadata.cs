using System.Collections.Generic;

namespace GeoserverManager.DAL.Interface.Datamodel.FeatureType
{
    public interface IMetadata
    {
        IEnumerable<IEntry> Entry { get; set; }
    }
}
using System.Collections.Generic;

namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IMetadata
    {
        IEnumerable<IEntry> Entry { get; set; }
    }
}
using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Datamodel
{
    public class Keywords : IKeywords
    {
        public IEnumerable<string> KeywordString { get; set; }
    }
}
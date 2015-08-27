using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public class Keywords : IKeywords
    {
        public IEnumerable<string> KeywordString { get; set; }
    }
}
using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Datamodel
{
    public class Namespace : INamespace
    {
        public string Name { get; set; }
        public string Href { get; set; }
    }
}
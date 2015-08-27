namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface IFeatureType
    {
        string Name { get; set; }
        string NativeName { get; set; }
        INamespace Namespace { get; set; }
        string Title { get; set; }
        IKeywords Keywords { get; set; }
        string srs { get; set; }
        INativeBoundingBox NativeBoundingBox { get; set; }
        ILatLonBoundingBox LatLonBoundingBox { get; set; }
        string ProjectionPolicy { get; set; }
        bool Enabled { get; set; }
        IMetadata Metadata { get; set; }
        IStore Store { get; set; }
        int MaxFeatures { get; set; }
        int NumDecimals { get; set; }
        bool OverridingServiceSRS { get; set; }
        bool CircularArcPresent { get; set; }
        IAttributes Attributes { get; set; }
    }
}
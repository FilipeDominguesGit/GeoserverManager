namespace GeoserverManager.DAL.Interface.Datamodel.FeatureType
{
    public interface IFeatureType
    {
        string Name { get; set; }

        string Title { get; set; }

        string srs { get; set; }


        string ProjectionPolicy { get; set; }
        bool Enabled { get; set; }

        IMetadata Metadata { get; set; }

        bool OverridingServiceSRS { get; set; }
        bool CircularArcPresent { get; set; }
    }
}
namespace GeoserverManager.DAL.UI.Repositories.ConfigData
{
    public interface IConfigurationDataGateway
    {
        string LocalLayersConnectionString { get; }

        string GeoServerUri { get; }
        string GeoServerUser { get; }
        string GeoServerPassword { get; }
    }
}
namespace GeoserverManager.DAL.UI.Repositories.ConfigData
{
    public interface IConfigurationDataGateway
    {
        string LocalLayersConnectionString { get; }

        string GeoServerUri { get; set; }
        string GeoServerUser { get; set; }
        string GeoServerPassword { get; set; }
    }
}
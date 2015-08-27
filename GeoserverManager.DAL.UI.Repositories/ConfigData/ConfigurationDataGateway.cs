using System.Configuration;

namespace GeoserverManager.DAL.UI.Repositories.ConfigData
{
    public class ConfigurationDataGateway : IConfigurationDataGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";

        public string LocalLayersConnectionString
        {
            get
            {
                var appSetting = ConfigurationManager.AppSettings[LocalLayersConnectionStringName].ToString();
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get Local Layers connection string!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }
    }
}
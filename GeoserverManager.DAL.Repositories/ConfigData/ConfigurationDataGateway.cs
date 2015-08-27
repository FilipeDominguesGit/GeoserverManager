using System.Configuration;
using GeoserverManager.DAL.Repositories.Properties;

namespace GeoserverManager.DAL.Repositories.ConfigData
{
    public class ConfigurationDataGateway : IConfigurationDataGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";

        public string LocalLayersConnectionString
        {
            get
            {
                var appSetting = Settings.Default[LocalLayersConnectionStringName].ToString();
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
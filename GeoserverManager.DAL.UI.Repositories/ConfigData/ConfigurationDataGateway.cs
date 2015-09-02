using System.Configuration;

namespace GeoserverManager.DAL.UI.Repositories.ConfigData
{
    public class ConfigurationDataGateway : IConfigurationDataGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";
        private const string GeoServerUriName = "GeoServerUri";
        private const string GeoServerUserName = "GeoServerUser";
        private const string GeoServerPasswordName = "GeoServerPassword";

        public string LocalLayersConnectionString
        {
            get
            {
                var appSetting = ConfigurationManager.AppSettings[LocalLayersConnectionStringName];
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get Local Layers connection string!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }

        public string GeoServerUri
        {
            get
            {
                var appSetting = ConfigurationManager.AppSettings[GeoServerUriName];
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServer Uri!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }

        public string GeoServerUser
        {
            get
            {
                var appSetting = ConfigurationManager.AppSettings[GeoServerUserName];
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServerUserName!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }

        public string GeoServerPassword
        {
            get
            {
                var appSetting = ConfigurationManager.AppSettings[GeoServerPasswordName];
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServer Password!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }
    }
}
using System;
using System.Configuration;
using System.Reflection;
using GeoserverManager.DAL.UI.Repositories.Security;

namespace GeoserverManager.DAL.UI.Repositories.ConfigData
{
    public class ConfigurationDataGateway : IConfigurationDataGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";
        private const string GeoServerUriName = "GeoServerUri";
        private const string GeoServerUserName = "GeoServerUser";
        private const string GeoServerPasswordName = "GeoServerPassword";
        private Configuration Config { get; set; }

        public ConfigurationDataGateway()
        {
            string appPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "App.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            Config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

        }

       

        public string LocalLayersConnectionString
        {
            get
            {
                var appSetting = Config.AppSettings.Settings[LocalLayersConnectionStringName].Value;
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get Local Layers connection string!";
                    throw new ConfigurationErrorsException(message);
                }
                return HashUtils.Decrypt(appSetting, "GeoserverManager");
            }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Config.AppSettings.Settings[LocalLayersConnectionStringName].Value = HashUtils.Encrypt(value,"GeoserverManager");
                Config.Save();
            }
        }

        public string GeoServerUri
        {
            get
            {
                var appSetting = Config.AppSettings.Settings[GeoServerUriName].Value;
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServer Uri!";
                    throw new ConfigurationErrorsException(message);
                }
                return HashUtils.Decrypt(appSetting, "GeoserverManager");
            }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Config.AppSettings.Settings[GeoServerUriName].Value= HashUtils.Encrypt(value, "GeoserverManager");
                Config.Save();
            }
        }

        public string GeoServerUser
        {
            get
            {
                var appSetting = Config.AppSettings.Settings[GeoServerUserName].Value;
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServerUserName!";
                    throw new ConfigurationErrorsException(message);
                }
                return HashUtils.Decrypt(appSetting, "GeoserverManager");
            }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Config.AppSettings.Settings[GeoServerUserName].Value = HashUtils.Encrypt(value, "GeoserverManager");
                Config.Save();
            }
        }

        public string GeoServerPassword
        {
            get
            {
                var appSetting = Config.AppSettings.Settings[GeoServerPasswordName].Value;
                if (string.IsNullOrWhiteSpace(appSetting))
                {
                    const string message = "Unable to get GeoServer Password!";
                    throw new ConfigurationErrorsException(message);
                }
                return HashUtils.Decrypt(appSetting, "GeoserverManager");
            }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Config.AppSettings.Settings[GeoServerPasswordName].Value = HashUtils.Encrypt(value, "GeoserverManager");
                Config.Save();
            }
        }
    }
}
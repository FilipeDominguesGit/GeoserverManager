using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.IoC.Spike.Security;

namespace GeoserverManager.IoC.Spike
{
    public class ConfigGateway :IConfigGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";
        private Configuration Config { get; set; }


        public ConfigGateway()
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
                Config.AppSettings.Settings[LocalLayersConnectionStringName].Value = HashUtils.Encrypt(value, "GeoserverManager");
                Config.Save();
            }
        }
    }
}

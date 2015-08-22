using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.DAL.Repositories.ConfigData
{
    public class ConfigurationDataGateway: IConfigurationDataGateway
    {
        private const string LocalLayersConnectionStringName = "LocalLayersConnectionString";

        public string LocalLayersConnectionString
        {
            get
            {
                string appSetting = Properties.Settings.Default[LocalLayersConnectionStringName].ToString();
                if (string.IsNullOrWhiteSpace( appSetting ))
                {
                    const string message = "Unable to get Local Layers connection string!";
                    throw new ConfigurationErrorsException(message);
                }
                return appSetting;
            }
        }

      
    }
}

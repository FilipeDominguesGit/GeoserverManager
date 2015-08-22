using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.DAL.Repositories.ConfigData
{
    public interface IConfigurationDataGateway
    {
        string LocalLayersConnectionString { get; }
    }
}

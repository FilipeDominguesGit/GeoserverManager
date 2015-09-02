using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.Rest.Client.Interface;
using GeoserverManager.UseCases.Interface.Repositories;

namespace GeoserverManager.IoC.Installers
{
    public class GeoserverRestClientInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
               .For<IGeoserverRestClient>()
               .ImplementedBy<GeoserverRestClient>().DependsOn(new
               {
                   restService = container.Resolve<IRestService>()
               })
               .LifestyleTransient());
        }
    }
}

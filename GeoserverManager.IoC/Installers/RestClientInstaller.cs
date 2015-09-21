using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.UI.Repositories.ConfigData;
using GeoserverManager.Rest.Client;
using GeoserverManager.Rest.Client.Interface;

namespace GeoserverManager.IoC.Installers
{
    public class RestClientInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IRestService>()
                .ImplementedBy<RestService>()
                .DependsOn(new
                {
                    uri = container.Resolve<IConfigurationDataGateway>().GeoServerUri,
                    user = container.Resolve<IConfigurationDataGateway>().GeoServerUser,
                    password = container.Resolve<IConfigurationDataGateway>().GeoServerPassword
                })
                .LifestyleTransient());
        }
    }
}
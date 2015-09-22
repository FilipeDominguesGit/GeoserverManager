using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.Rest.Client.Interface;

namespace GeoserverManager.IoC.Installers
{
    public class GeoserverRestClientInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IGeoserverRestClient>()
                .ImplementedBy<GeoserverRestClient>()
                //.DependsOn(new
                //{
                //    restService = container.Resolve<IRestService>()
                //})
                .DynamicParameters((p, k) =>
                {
                    var restService = p.Resolve<IRestService>();
                    k["restService"] = restService;

                })
                .LifestyleTransient());
        }
    }
}
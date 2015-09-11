using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.UseCases.Interface.Repositories;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.UseCases.Layers;

namespace GeoserverManager.IoC.Installers
{
    public class UseCasesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IGetAllLayersUseCase>()
                .ImplementedBy<GetAllLayersUseCase>().DependsOn(new
                {
                    repository = container.Resolve<ILayerInfoRepository>()
                })
                .LifestyleTransient());


            container.Register(Component
                .For<IGetLayerStatusUseCase>()
                .ImplementedBy<GetLayerStatusUseCase>().DependsOn(new
                {
                    restClient = container.Resolve<IGeoserverRestClient>()
                })
                .LifestyleTransient());
        }
    }
}
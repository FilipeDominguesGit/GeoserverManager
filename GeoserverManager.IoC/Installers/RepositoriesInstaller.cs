using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.Repositories.Repositories;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
using GeoserverManager.UseCases.Interface.Repositories;

namespace GeoserverManager.IoC.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<ILayerInfoRepository>()
                .ImplementedBy<LayerInfoRepository>().DependsOn(new
                {
                    gateway = container.Resolve<IGeoEntityJsonGateway>(),
                    builderPrototype = container.Resolve<ILayerInfoBuilderPrototype>()
                })
                .LifestyleTransient());
        }
    }
}
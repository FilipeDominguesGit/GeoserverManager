using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.UI.Repositories;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
using GeoserverManager.UseCases.Interface.Repositories;

namespace GeoserverManager.IoC.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IFeatureTypeInfoRepository>()
                .ImplementedBy<FeatureTypeInfoRepository>()
                //.DependsOn(new
                //{
                //    gateway = container.Resolve<IGeoEntityJsonGateway>(),
                //    builderPrototype = container.Resolve<ILayerInfoBuilderPrototype>()
                //})
                .DynamicParameters((p, k) =>
                {
                    var gateway = container.Resolve<IGeoEntityJsonGateway>();
                    var builderPrototype = container.Resolve<IFeatureTypeInfoBuilderPrototype>();

                    k["gateway"] = gateway;
                    k["builderPrototype"] = builderPrototype;

                })
                .LifestyleTransient());
        }
    }
}
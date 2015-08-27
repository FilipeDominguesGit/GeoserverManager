using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.Entities.BussinessModelFactories;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.IoC.Installers
{
    public class BuilderPrototypeInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<ILayerInfoBuilderPrototype>()
                .ImplementedBy<LayerInfoBuilder>()
                .LifestyleTransient());
        }
    }
}
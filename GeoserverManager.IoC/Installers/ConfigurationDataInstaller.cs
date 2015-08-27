using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.UI.Repositories.ConfigData;

namespace GeoserverManager.IoC.Installers
{
    public class ConfigurationDataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IConfigurationDataGateway>()
                .ImplementedBy<ConfigurationDataGateway>()
                .LifestyleTransient());

            //container.Register(AllTypes.FromAssemblyNamed("GeoserverManager.DAL.Repositories")
            //    .BasedOn(typeof(IConfigurationDataGateway))
            //    .WithService.AllInterfaces()
            //    .LifestyleTransient());
        }
    }
}
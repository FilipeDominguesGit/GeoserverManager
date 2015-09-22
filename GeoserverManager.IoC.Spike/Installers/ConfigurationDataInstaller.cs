using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace GeoserverManager.IoC.Spike.Installers
{
    public class ConfigurationDataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IConfigGateway>()
                .ImplementedBy<ConfigGateway>()
                .LifestyleTransient());

            //container.Register(AllTypes.FromAssemblyNamed("GeoserverManager.DAL.Repositories")
            //    .BasedOn(typeof(IConfigurationDataGateway))
            //    .WithService.AllInterfaces()
            //    .LifestyleTransient());
        }
    }
}
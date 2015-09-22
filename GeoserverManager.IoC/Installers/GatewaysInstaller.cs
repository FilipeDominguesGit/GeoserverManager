using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.Gateways;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.UI.Repositories.ConfigData;

namespace GeoserverManager.IoC.Installers
{
    public class GatewaysInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IGeoEntityJsonGateway>()
                .ImplementedBy<GeoEntityJsonGateway>()
                //.DependsOn(new
                //{
                //    connectionString = container.Resolve<IConfigurationDataGateway>().LocalLayersConnectionString
                //})
                 .DynamicParameters((p, k) =>
                 {
                     var gate = p.Resolve<IConfigurationDataGateway>();
                     k["connectionString"] = gate.LocalLayersConnectionString;

                 })
                .LifestyleTransient());
        }
    }
}
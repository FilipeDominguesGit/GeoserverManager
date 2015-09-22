using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace GeoserverManager.IoC.Spike.Installers
{
    public class GatewaysInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<ITestIocGateway>()
                .ImplementedBy<TestIocGateway>()
                //.DependsOn(new
                //{
                //    connectionString = container.Resolve<IConfigGateway>().LocalLayersConnectionString
                //})
                .DynamicParameters((p, k) =>
                {
                    var gate = p.Resolve<IConfigGateway>();
                    k["connectionString"] = gate.LocalLayersConnectionString;

                })
                .LifestyleTransient());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using GeoserverManager.IoC.Installers;

namespace GeoserverManager.IoC.Container
{
    public static class IocContainer
    {
        private static readonly IWindsorContainer _container = Bootstrap();

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        private static IWindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();
            container.Install(new ConfigurationDataInstaller(),
                new BuilderPrototypeInstaller(),
                new GatewaysInstaller(),
                new RepositoriesInstaller(),
                new UseCasesInstaller());

            

            return container;
        }
    }
}

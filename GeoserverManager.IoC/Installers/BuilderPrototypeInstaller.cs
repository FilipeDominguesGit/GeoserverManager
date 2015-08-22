using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.Repositories.ConfigData;
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
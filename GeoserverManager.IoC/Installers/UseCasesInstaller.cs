using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.Repositories.Repositories;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
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
                 repository=container.Resolve<ILayerInfoRepository>()   
                })
                .LifestyleTransient());
        }
    }

}
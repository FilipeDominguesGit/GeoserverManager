using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.IoC.Spike
{
    class Program
    {
        static void Main(string[] args)
        {
            var gateway = IocContainer.Resolve<ITestIocGateway>();
            var config = IocContainer.Resolve<IConfigGateway>();

            Console.Write(gateway.GetConn());

            config.LocalLayersConnectionString = "asdas";

            gateway = IocContainer.Resolve<ITestIocGateway>();

            Console.WriteLine(gateway.GetConn());

            Console.ReadKey();
        }
    }
}

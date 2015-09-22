using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.IoC.Spike
{
   public class TestIocGateway :ITestIocGateway
   {
       private string conn;

       public TestIocGateway(string connectionString)
       {
           this.conn = connectionString;
       }

       public string GetConn()
       {
           return conn;
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Rest.Client.Request;

namespace GeoserverManager.Rest.Client.Spike
{
    class Program
    {
        static void Main(string[] args)
        {
            var restService=new RestService("http://jsonplaceholder.typicode.com/");

            var response=restService.Get(new ServiceRequest("Posts/1"));

            Console.WriteLine(response.StatusCode.ToString());
            Console.WriteLine(response.Data);

            Console.ReadKey();

        }
    }
}

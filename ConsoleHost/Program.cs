using EvalServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EvalService));
            try
            {
                //host.AddServiceEndpoint(typeof(IEvalService), new BasicHttpBinding(), "another");
                host.Open();
                PrintServiceInfo(host);
                Console.ReadLine();
                host.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                host.Abort();
            }
        }

        public static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} is running with follow endpoint", host.Description.ServiceType);
            foreach(ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}

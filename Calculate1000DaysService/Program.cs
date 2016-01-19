using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Calculate100DaysLibrary;

namespace Calculate1000DaysService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Calculate1000DaysLibrary");
            using (var host = new ServiceHost(typeof(CalculateDaysClass),baseAddress))
            {
                host.AddServiceEndpoint(typeof (ICalculateDaysClass), new WSHttpBinding(), "CalculateDaysClass");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceMetadataBehavior);

                host.Open();
                Console.WriteLine("Tjänsten startas nu! :)");
                Console.ReadLine();
            }
        }
    }
}

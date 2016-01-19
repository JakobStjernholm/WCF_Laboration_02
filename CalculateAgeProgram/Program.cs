using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using CalculateAgeLibrary;

namespace CalculateAgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/CalculateAgeLibrary");
            ServiceHost host = new ServiceHost(typeof(CalculateAgeClass),baseAddress);
            //using (host)
            //{
                host.AddServiceEndpoint(typeof(ICalculateAgeClass),
                    new WSHttpBinding(),
                    "CalculateAgeClass");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceMetadataBehavior);

                host.Open();
                Console.WriteLine("Tjänsten startas!! :)");
                Console.ReadLine();
            host.Close();
            //}

        }
    }
}

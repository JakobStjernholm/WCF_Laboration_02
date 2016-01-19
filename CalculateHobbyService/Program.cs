using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHobby;

namespace CalculateHobbyService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ClassLibraryHobby");
            using (var host = new ServiceHost(typeof(WordClass),baseAddress))
            {
                host.AddServiceEndpoint(typeof (IWordClass), new WSHttpBinding(), "WordClass");
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;

                host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.Open();

                Console.WriteLine("Den sista tjänsten startas!");
                Console.ReadLine();
            }
        }
    }
}

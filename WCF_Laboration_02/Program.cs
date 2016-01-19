using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ClassLibraryCalculateBMI;

namespace WCF_Laboration_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/ClassLibraryCalculateBMI");
            ServiceHost host = new ServiceHost(typeof(CalculateBMI), baseAddress);
            try
            {

                host.AddServiceEndpoint((typeof(ICalculateBMI)),
                    new BasicHttpBinding(),
                    "CalculateBMI");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceMetadataBehavior);

                host.Open();
                Console.WriteLine("Tjänsten startas!");
                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadLine();
                host.Abort();
                throw;
            }
            finally
            {
                host.Close();
            }

        }
    }
}

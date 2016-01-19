using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculateBMI
{
    public class CalculateBMI : ICalculateBMI
    {
        public double CalculateBmi(double length, double weight)
        {
            return weight/(length*length);
        }
    }
    [ServiceContract(Namespace = "http://ClassLibraryCalculateBMI")]
    public interface ICalculateBMI
    {
        [OperationContract]
        double CalculateBmi(double length, double weight);
    }
}

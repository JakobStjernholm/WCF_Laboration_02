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
        public int CalculateBmi(int length, int weight)
        {
            return weight/(length*length);
        }
    }
    [ServiceContract(Namespace = "http://ClassLibraryCalculateBMI")]
    public interface ICalculateBMI
    {
        [OperationContract]
        int CalculateBmi(int length, int weight);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgeLibrary
{
    public class CalculateAgeClass : ICalculateAgeClass
    {
        public int GetDays(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            return age;
        }
    }
    [ServiceContract(Namespace = "http://CalculateAgeLibrary")]
    public interface ICalculateAgeClass
    {
        [OperationContract]
        int GetDays(DateTime birthday);
    }
}

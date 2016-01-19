using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Calculate100DaysLibrary
{
    public class CalculateDaysClass : ICalculateDaysClass
    {
        public DateTime GetNextDateWhen1000(string date)
        {
            var birthdate = DateTime.Parse(date);
            var now = DateTime.Now;
            TimeSpan elapsed = now.Subtract(birthdate);
            var resten = elapsed.TotalDays % 1000;
            var datum = 1000 - resten;
            return DateTime.Now.AddDays(datum);
        }
    }
    [ServiceContract(Namespace = "http://Calculate1000DaysLibrary")]
    public interface ICalculateDaysClass
    {
        [OperationContract]
        DateTime GetNextDateWhen1000(string date);
    }
}

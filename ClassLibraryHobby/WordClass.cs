using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHobby
{
    public class WordClass : IWordClass
    {
        public int GetNumberOfWords(string sentence)
        {
            var array = sentence.Split(' ');
            return array.Length;
        }
    }
    [ServiceContract(Namespace = "http://ClassLibraryHobby")]
    public interface IWordClass
    {
        [OperationContract]
        int GetNumberOfWords(string sentence);
    }
}

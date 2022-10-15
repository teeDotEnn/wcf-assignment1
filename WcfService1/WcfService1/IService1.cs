using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAssignmentService" in both code and config file together.
    [ServiceContract]
    public interface IAssignmentService
    {


        [OperationContract]
        bool IsPrimeNumber(int input);
        [OperationContract]
        int SumOfDigits(int input);
        [OperationContract]
        string ReverseString(string input);
        [OperationContract]
        string AddHtmlTag(string tag, string data);
        [OperationContract]
        List<int> SortNumbers(List<int> numbers, string direction);

        // TODO: Add your service operations here
    }


}

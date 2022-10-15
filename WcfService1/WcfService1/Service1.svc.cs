using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AssignmentService : IAssignmentService
    {
        public string AddHtmlTag(string tag, string data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            sb.Append(tag);
            sb.Append(">");
            sb.Append(data);
            sb.Append("</");
            sb.Append(tag);
            sb.Append('>');
            return sb.ToString();
        }

        public bool IsPrimeNumber(int input)
        {
            //This uses a primality test with the 6k+-1 optimization
       
            if (input == 2||input == 3)
            {
                return true;
            }

            if(input<=1||input%2 == 0 || input%3 == 0)
            {
                return false;
            }

            for(int i = 5; i * i<=input; i += 6)
            {
                if(input % i == 0 || input % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public string ReverseString(string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }   

        public List<int> SortNumbers(List<int> numbers, string direction)
        {
            if (direction.ToLower().Contains("asc")) 
            {
                return numbers.OrderBy(x=>x).ToList();
  
            }

            if (direction.ToLower().Contains("desc"))
            {
                return numbers.OrderBy(x => x).Reverse().ToList();
            }

            return new List<int>();
        }

        public int SumOfDigits(int input)
        {
            string digits = input.ToString();
            int result = 0;
            foreach(char digit in digits)
            {
                result +=  (int)char.GetNumericValue(digit);
            }
            return result;
        }
    }
}

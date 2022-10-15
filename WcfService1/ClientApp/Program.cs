using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.IAssignmentService service = new ServiceReference1.AssignmentServiceClient();
            List<string> menuOptions = new List<string> { "Prime Number", 
                "Sum of Digits", 
                "Reverse a string", 
                "Print HTML tags", 
                "Sort 5 numbers",
                "Exit"
            };
            Console.WriteLine("\t\tWCF Assignment 1");
            string input = String.Empty;
            while(input != menuOptions.Count.ToString())
            {
                for(int i = 0; i < menuOptions.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {menuOptions[i]}");
                }
                Console.Write("\tEnter your choice: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please enter an integer");
                        if (service.IsPrimeNumber(int.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("Your number is prime");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Your number is not prime");
                            Console.WriteLine();
                        };
                        break;
                    case "2":
                        Console.WriteLine("Please enter an integer");
                        Console.WriteLine($"The sum of digits in your number is: {service.SumOfDigits(int.Parse(Console.ReadLine()))}");
                        break;
                    case "3":
                        Console.WriteLine("Please enter a string");
                        Console.WriteLine($"Your string reversed is: {service.ReverseString(Console.ReadLine())}");
                        break;
                    case "4":
                        Console.WriteLine("Please enter an html tag (eg h1)");
                        string tag = Console.ReadLine();
                        Console.WriteLine("Please enter the contents of the tag");
                        string content = Console.ReadLine();
                        Console.WriteLine("The tag with contents is: " + service.AddHtmlTag(tag, content));
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "5":
                        List<int> nums = new List<int>();
                        for(int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Please enter integer {i + 1}");
                            nums.Add(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine("Do you want numbers sorted in ascending or descending order?");
                        string order = Console.ReadLine();
                        var result = service.SortNumbers(nums.ToArray(), order);
                        if (result.Length != 0)
                        {
                            Console.WriteLine("Your numbers are: ");
                            for(int i = 0; i<result.Length;i++) 
                            {
                                Console.Write(result[i].ToString());
                                if(i+1 != result.Length)
                                {
                                    Console.Write(",");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("An error occurred, please try again");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }
        
        
    }
}

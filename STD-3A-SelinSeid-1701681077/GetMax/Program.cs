using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
          static int GetMax(int firstNumber, int secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    return firstNumber;
                }
                else
                {
                    return secondNumber;
                }

            }
            static void Main(string[] args)
            {

                Console.WriteLine("Enter the first number:");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third number:");
                int thirdNumber = int.Parse(Console.ReadLine());
                Console.Write("The biggest number is ");
                Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));

            }
        
    }
    
}

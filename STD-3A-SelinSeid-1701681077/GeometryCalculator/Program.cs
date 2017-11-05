using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Choose option(triangle,square or radians):");
                Console.Write("Your option:");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "triangle":Triangle();
                        break;
                    case "square":Square();
                        break;
                    case "radians":Radians();
                        break;
                    case "exit":Environment.Exit(0);
                        break;
                    default:Console.WriteLine("That's not an option!");
                        break;
                }
            }
        }
            static void Triangle()
            {

                Console.Write("Enter a side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter a height: ");
                double height = double.Parse(Console.ReadLine());
                double S = (side * height) / 2;
                Console.WriteLine("The area of the triangle is: {0:F2}", S);
            }
            static void Square()
            {
                Console.WriteLine("Enter a side: ");
                double side = double.Parse(Console.ReadLine());
                double S = (side * side);
                Console.WriteLine("The area of the square is: {0:F2}", S);

            }
            static void Radians()
            {

                Console.Write("Enter the degree you want to transform in radians: ");
                double degree = double.Parse(Console.ReadLine());
                double radians = (Math.PI / 180) * degree;
                Console.WriteLine("Your deegree in radians is: {0}", radians);


            }
        
    }
}

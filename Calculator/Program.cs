using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static int num1;
        static int num2;
        static int num3;
        static string answer;


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome, this is a calculator");
                Console.WriteLine("Please enter your first number: ");

                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your second number: ");

                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select an operation: ");
                Console.WriteLine(" 1: Addtion \n 2: Subtraction \n 3: Multiplication \n 4: Division \n 5: Finish Program");

                answer = Console.ReadLine();


                if (answer == "1")
                {
                    num3 = num1 + num2;
                    Console.WriteLine($"Result: {num3}");
                }
                else if (answer == "2")
                {
                    num3 = num1 - num2;
                    Console.WriteLine($"Result: {num3}");
                }
                else if (answer == "3")
                {
                    num3 = num1 * num2;
                    Console.WriteLine($"Result: {num3}");
                }
                else if (answer == "4")
                {
                    if (num1 != 0)
                    {
                        num3 = num1 / num2;
                        Console.WriteLine($"Result: {num3}");

                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                    }

                }
                else if (answer == "5")
                {
                    Console.WriteLine("Program finished");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please enter a valid operation");
                }
                Console.WriteLine();

            }
        }
    }
}
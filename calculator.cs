using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;
            
            Console.WriteLine("Hello, Welcome to the calculator program!");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.toInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter your second number.")

            num2 = Convert.toInt32(Console.ReadLine());

            Console.WriteLine("Whta type of operation would you like to do?")
            Console.WriteLine("Please enter aa for addition, s for subtraction, m for multiplication or any other key for division.")

            answer =  Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if(answwer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is" + result);
            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}

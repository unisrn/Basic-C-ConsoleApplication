using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            do
            {
                Console.WriteLine("------------------- MENU -------------------");
                Console.WriteLine("1. Hello World");
                Console.WriteLine("2. Hello Name");
                Console.WriteLine("3. Calculator");
                Console.WriteLine("4. Even or Odd Number");
                Console.WriteLine("5. Multiplication");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Input your choice: ");
                choice = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");

                if (choice == "0")
                {
                    Console.WriteLine("End Program");
                    Console.WriteLine("--------------------------------------------");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hello World!!!");
                        break;
                    case "2":
                        Console.Write("Please input your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("\n>>> Hello " + name);
                        break;
                    case "3":
                        Console.WriteLine("1. Add | 2. Minus | 3. Multiple | 4. Divide");
                        Console.Write("Select operator (number 1 - 4): ");
                        string operation = Console.ReadLine();
                        Console.Write("Input number1: ");
                        int num1 = Int32.Parse(Console.ReadLine());
                        Console.Write("Input number1: ");
                        int num2 = Int32.Parse(Console.ReadLine());
                        calculator(operation, num1, num2);
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            } while (choice != "0");
            

            Console.ReadKey();
        }

        public static void calculator(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "1":
                    int resAdd = num1 + num2;
                    Console.WriteLine("\n>>> " + num1 + " + " + num2 + " = " + resAdd);
                    break;
                case "2":
                    int resMinus = num1 - num2;
                    Console.WriteLine("\n>>> " + num1 + " - " + num2 + " = " + resMinus);
                    break;
                case "3":
                    int resMuliple = num1 * num2;
                    Console.WriteLine("\n>>> " + num1 + " x " + num2 + " = " + resMuliple);
                    break;
                case "4":
                    int resDivide = num1 / num2;
                    Console.WriteLine("\n>>> " + num1 + " / " + num2 + " = " + resDivide);
                    break;
                default:
                    Console.WriteLine("Invalid Case");
                    break;
            }
        }
    }
}

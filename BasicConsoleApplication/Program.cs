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
                        Console.WriteLine("\n>>> Hello World!!!");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("Input your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("\n>>> Hello " + name);
                        Console.WriteLine();
                        break;
                    case "3":
                        string operation = "";
                        Console.WriteLine("1. Add | 2. Minus | 3. Multiple | 4. Divide");
                        
                        do
                        {
                            Console.Write("Select operator (number 1 - 4): ");
                            operation = Console.ReadLine();
                        } while (operation != "1" && operation != "2" && operation != "3" && operation != "4");

                        Console.WriteLine();

                        int num1 = 0, num2 = 0;

                        do
                        {
                            Console.Write("Input number1: ");
                            num1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Input number1: ");
                            num2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------");
                        } while (num1 < num2);
                        
                        Calculator(operation, num1, num2);
                        break;
                    case "4":
                        Console.Write("Input the number you want to check: ");
                        int checkNumber = Int32.Parse(Console.ReadLine());
                        CheckEvenOrOdd(checkNumber);
                        break;
                    case "5":
                        Console.Write("Input Multiplier: ");
                        int multiplier = Int32.Parse(Console.ReadLine());
                        ResultOfMuliple(multiplier);
                        break;
                    default:
                        Console.WriteLine("\n>>> Please try again");
                        Console.WriteLine();
                        break;
                }
            } while (choice != "0");


            Console.ReadKey();
        }

        public static void Calculator(string operation, int num1, int num2)
        {
            switch (operation)
            {
                case "1":
                    int resAdd = num1 + num2;
                    Console.WriteLine("\n>>> " + num1 + " + " + num2 + " = " + resAdd);
                    Console.WriteLine();
                    break;
                case "2":
                    int resMinus = num1 - num2;
                    Console.WriteLine("\n>>> " + num1 + " - " + num2 + " = " + resMinus);
                    Console.WriteLine();
                    break;
                case "3":
                    int resMuliple = num1 * num2;
                    Console.WriteLine("\n>>> " + num1 + " x " + num2 + " = " + resMuliple);
                    Console.WriteLine();
                    break;
                case "4":
                    int resDivide = num1 / num2;
                    Console.WriteLine("\n>>> " + num1 + " / " + num2 + " = " + resDivide);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Case");
                    break;
            }
        }

        public static void CheckEvenOrOdd(int checkNumber)
        {
            if (checkNumber % 2 == 0)
            {
                Console.WriteLine("\n>>> Even number");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n>>> Odd number");
                Console.WriteLine();
            }
        }

        public static void ResultOfMuliple(int multiplier)
        {
            for (int i = 1; i < 13; i++)
            {
                int resMultiplier = multiplier * i;
                Console.WriteLine("\n>>> " + multiplier + " x " + i + " = " + resMultiplier);
            }
            Console.WriteLine();
        }
    }
}

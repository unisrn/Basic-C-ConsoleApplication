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
                Console.WriteLine("4. Prime Number");
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
                        while (true)
                        {
                            Console.WriteLine("1. Is the prime number ? | 2. The total number of prime number");
                            Console.Write("Select choice: ");
                            string choicePrime = Console.ReadLine();

                            if (choicePrime == "1" || choicePrime == "2")
                            {
                                CheckPrime(choicePrime);
                                break;
                            }
                        }
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

        public static void CheckPrime(string checkPrime)
        {
            int countCheck = 0;

            if (checkPrime == "1")
            {
                Console.Write("Input your number: ");
                int primeNumber = Int32.Parse(Console.ReadLine());

                for (int i = 1; i <= primeNumber; i++)
                {
                    int resPrime = primeNumber % i;
                    if (resPrime == 0)
                    {
                        countCheck += 1;
                    }
                }
                if (countCheck == 2)
                {
                    Console.WriteLine("\n>>> " + primeNumber + " is a prime number");
                }
                else
                {
                    Console.WriteLine("\n>>> " + primeNumber + " is not a prime number");
                }

                Console.WriteLine();
            }
            else
            {
                Console.Write("Input the total of number: ");
                int totalPrime = Int32.Parse(Console.ReadLine());

                Console.Write("\n>>> ");
                int chcekTotal = 0;
                for (int i = 0; i < 100; i++)
                {
                    int check = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            check += 1;
                        }
                    }
                    if (check == 2)
                    {
                        chcekTotal += 1;
                        if (chcekTotal <= totalPrime)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }

                Console.WriteLine("\n");
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

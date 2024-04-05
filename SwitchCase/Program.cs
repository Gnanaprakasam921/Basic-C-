using System;
using System.Collections;
namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1");
            double Number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double Number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Your operation:");
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                {
                    Console.WriteLine(Number1 + Number2);
                    break;
                } 
            
                case '-':
                {
                    Console.WriteLine(Number1 - Number1);
                    break;
                }
            case '*':
                {
                    Console.WriteLine(Number1 * Number2);
                    break;
                }
            case '/':
                {


                    Console.WriteLine(Number1 / Number2);
                    break;
                }
            case '%':
                {


                    Console.WriteLine(Number1 % Number2);
                    break;
                }
                default:
                {
                    Console.WriteLine("invalid");
                    break;
                }

            }
    }
    
        }
}
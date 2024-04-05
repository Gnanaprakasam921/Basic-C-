using System;
namespace ForLoop
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int total =0,squre;
            Console.WriteLine("Enter the start number:");
            int Number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end value:");
            int Number2=int.Parse(Console.ReadLine());
            for (int i=Number1;i<=Number2;i++)
            {
                squre=i*i;
                total=total + squre;
                
            }
            Console.WriteLine("total="+total);
        }
    }
}
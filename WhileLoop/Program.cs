using System;
namespace WhileLoop
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i=0;
            while (i<25)
            {
                if (i%2==0)
                Console.WriteLine(i);
                i++;

            }
            
            int output =0;
            Console.WriteLine("Enter the Number");
            bool isValid=int.TryParse(Console.ReadLine(), out output );
            while(!isValid)
            {
                Console.WriteLine("invalid: again enger");
                isValid=int.TryParse(Console.ReadLine(), out output );
            }


            





            
        }
    }
}

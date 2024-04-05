using System;
namespace Typeconversion
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark of subject 1:");
            double mark1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark of subject2:");
            double mark2=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter mark of subject3:");
            double mark3=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade:");
            char grade=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter mobile number:");
            long number=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mail id:");
            string mail=Console.ReadLine();
            Console.WriteLine("Trainee Details are:");
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Age:"+age);
            Console.WriteLine("Mark1:"+mark1);
            Console.WriteLine("Mark2:"+mark2);
            Console.WriteLine("Mark3:"+mark3);
            Console.WriteLine("Grade:"+grade);
            Console.WriteLine("Number:"+number);
            Console.WriteLine("Email:"+mail);


        }
    }
}
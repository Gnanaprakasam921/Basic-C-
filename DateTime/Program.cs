using System;
using System.Data;
using System.Security.Cryptography;
namespace Dateandtime
{
 class Program 
 {
    public static void Main(string[] args)
    {
        
        DateTime date= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
         DateTime date1= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        //Console.WriteLine(date.ToString("MM/dd/yyyy"));
        //Console.WriteLine(date.DayOfWeek);
       // Console.WriteLine(date)
       TimeSpan date3=date1-date;

       Console.WriteLine(date3);
       //double a=Math.Round(date3.TotalDays);
       Console.WriteLine(date.DayOfWeek);
       //Console.WriteLine(Math.(date3.TotalDays));
        Console.WriteLine(Math.Floor((date3.TotalDays)/365));

        Console.WriteLine(Math.Round(date3.TotalDays));
       Console.WriteLine(Math.Round(date3.TotalHours));
       Console.WriteLine(Math.Round(date3.TotalMinutes));


Differnts of two years
 TimeSpan span=today-dob;
 Console.WriteLine(span.TotalMinutes)
// Console.WriteLine(span.TotalDay);

// Console.WriteLine(span.Totalhours);
// Console.WriteLine(span.TotalMinunts);



        





        // Console.WriteLine("Enter your date and time: YYYY/MM/DD HH:mm:ss");
        // DateTime date= DateTime.ParseExact(Console.ReadLine(),"yyyy,MM,dd HH:mm:ss.tt",null);
        // TimeSpan span
        
        // Console.WriteLine(date);
        // Console.WriteLine("Date"+date.Day);
        //  Console.WriteLine("Month:"+date.Month);
        // Console.WriteLine("Year:"+date.Year);
        // Console.WriteLine("Hour:"+date.Hour);
        // Console.WriteLine("Min:"+date.Minute);
        // Console.WriteLine("Sec:"+date.Second);
        // Console.WriteLine(date.Millisecond);
        // Console.WriteLine(date.ToShortDateString());
        // Console.WriteLine(date.ToString())
        // Console.WriteLine(date.DayOfWeek)

        

        
       // Console.WriteLine(date.ToString("tt ss mm HH "))



        // string date1=(Console.ReadLine());
        // string[] s=date1.Split(':','/');
        // foreach (string i in s)
        // {
        //     Console.WriteLine(i);
        // }


    }

 }
}

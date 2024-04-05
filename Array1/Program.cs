using System;
namespace Array1
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
              int i;
              int flag=1;
              int n=int.Parse(Console.ReadLine());
              int k=int.Parse(Console.ReadLine());
              int[] arr=new int[n];
              for(i=0;i<n;i++)
              {
                arr[i]=int.Parse(Console.ReadLine());
              }
              for(i=0;i<n;i++)
              {
                if (arr[i]==k)
                {
                    flag=0;
                    Console.WriteLine(i);
                    
                }
                // else
                // {
                //     Console.WriteLine("-1");
                // }
              }
              if(flag==1)
              {
                Console.WriteLine("-1");
              }
          
        }
    }
}
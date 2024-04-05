using System;
namespace Array
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i;
            string[] arr1=new string[5];


            //using for loop
            for ( i=0;i<arr1.Length;i++)
            {
                arr1[i]=Console.ReadLine();
            }
            for (i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }


            string name=Console.ReadLine();
            for(i=0; i<arr1.Length;i++)
            {
                if (name==arr1[i])
                {
                    Console.WriteLine("The name is present:" +arr1[i]);
                    
                }
                else
                {
                    Console.WriteLine("Dosen't present");
                }



                //for each  

                
                foreach ( string j in arr1)
                {
                    Console.WriteLine(j);
                    
                    {

                         if (name==arr1[i])
                {
                    Console.WriteLine("The name is present:" +arr1[i]);
                    
                }
                else
                {
                    Console.WriteLine("Dosen't present");
                }

                    }
                }
                
                
            }

        }
    }
}
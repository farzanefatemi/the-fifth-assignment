using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your number:");  
           int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your single digit:");
            int digit=Convert.ToInt16(Console.ReadLine());
            int count=0;
            int x;

            for (int i = 0; i < number; i++)
            {
                x=number%10;
                if(x==digit){
                    count++;
                }
                number/=10;
                
            }
            Console.WriteLine(count);
        }


    }
}

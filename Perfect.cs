using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Perfect
    {
        static void Main(string[] args)
        {
            int sum = 0, num,temp;
            Console.WriteLine("Enter the Number");
            num=int.Parse(Console.ReadLine());

            temp = num;
            for (int i = 1; i < num; i++)
            { 
                if(num % i == 0)
                {
                    sum = sum + i;
                }


            }
            if (sum == temp) 
            {
                Console.WriteLine("The number is perfect number");
            }
            else
            {
                Console.WriteLine("The number is not perfect");
            }
        }
    }
}

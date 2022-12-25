using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please entre The first Number");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please entre The secound Number");
            int N2 = int.Parse(Console.ReadLine());
            int i, count;
            for (i = N1;i<= N2; i++)
            {
                for (count = 2; count< i ; count++)
               {

           
                if(i%count== 0 )
                {
                  break;
                }
                
                    
                }
            if (i == count)
            {
                Console.WriteLine("Number is prime {0} " ,i);

            }
                    
                    
            }
        }
    }
}

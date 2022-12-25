using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{ 
    class perfectNumber
    {
      int N1,N2;
        public perfectNumber(int N1, int N2)
        {
          this .  N1 = N1;
          this.  N2 = N2;
        }
        public void printNumber()
        {
            int i,sum;
            for (int n = N1;n <= N2; n++)
            {
                i =1;
                sum =0;
                while(i < n)
                {
                    if (n%i ==0)
                    {
                        sum =sum+i;
                    }
                    i++;
                }
                if (sum == n)
                {
                    Console.WriteLine("{0}",n);
                }
            }
        }
     }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please entre The first Number");
            int N1= int.Parse(Console.ReadLine());
            Console.WriteLine("please entre The secound Number");
            int N2= int.Parse(Console.ReadLine());
            perfectNumber p= new perfectNumber(N1,N2);
            p.printNumber();

        }
        
    }
}

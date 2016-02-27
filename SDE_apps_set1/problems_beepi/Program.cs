using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accept number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(isPrime(num1))
            {
                Console.WriteLine("It is prime");

            }
            else
            {
                Console.WriteLine("NOT prime");
                //Console.WriteLine("NOT prime");
            }

            Console.ReadKey();
        }

        public static Boolean isPrime(int num)
        {
            int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(num)));

            if (num == 1) return false;
            if (num == 2) return true;

            for(int i = 2; i <= boundary; ++i)
            {
                if (num % i == 0) return false;
            }

            return true;

        }
    }
}

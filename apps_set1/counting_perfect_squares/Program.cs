using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting_perfect_squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide two numbers A and B with A<B");
            long M = Convert.ToInt64(Console.ReadLine());
            long N = Convert.ToInt64(Console.ReadLine());
            int outputVal = perfectsquares(M, N);
            Console.WriteLine("Number of perfect squares are {0}", outputVal);
            Console.ReadKey();
        }

        public static int perfectsquares(long A, long B)
        {
            int count = 0;
            //Proceed if lower bound is less than upper bound
            if(A>B)
            {
                Console.WriteLine("Provide A as lower bound");
            }

            else
            {
                //negative numbers are not perfect squares
                if (A < 0 && B < 0) return count;

                //Reset lower bound if required
                if (A <= 0) A = 1;

                int sqrtA = Convert.ToInt32(Math.Floor(Math.Sqrt(A)));
                int sqrtB = Convert.ToInt32(Math.Floor(Math.Sqrt(B)));
                count = sqrtB - sqrtA;

                //To handle lower bound if it is a perfect square
                if (A == sqrtA * sqrtA) count++;

            }
            return count;
        }
    }
}

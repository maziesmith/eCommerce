using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming_Problems
{
    class Program
    {
        //overlapping subproblem - Fibonacci
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n value of fibonacci number");
            int argArray = Int32.Parse(Console.ReadLine());
            dpFib(argArray);

        }

        static void dpFib(int n)
        {
            //calculate nth fibonacci number using dynamic programming
            //create a lookup table.. array in this problem.. and fill up only on demand..

            int[] inputArray = new int[n];
            if (n < 1)
            { Console.WriteLine("invalid input"); }

            else
            {
                for (int j = 0; j < n; j++)
                {
                    if (inputArray.IsEmpty(j))

                    {
                        if (j == 0 || j == 1)
                        {
                            inputArray[j] = 1;
                        }
                        else
                        {
                            inputArray[j] = inputArray[j - 1] + inputArray[j - 2];
                        }
                    }
                }
            }

            Console.WriteLine("The value of nth fibonacci number as per DP-memorization is:{0}", inputArray[n - 1]);
            Console.ReadKey();

        }

        //extension method created to check if the element of array is empty
        // when int[] array is instantiated, by default all its values are assigned to zero.


    }

    public static class Extensions
    {
         public static bool IsEmpty(this int[] checkArray, int x)
        {
            return (checkArray[x] == 0);
        }
    }
}

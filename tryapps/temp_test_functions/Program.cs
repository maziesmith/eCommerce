using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_test_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArrayData = "1 4 89 23 57";
            string[] outputArrayData = inputArrayData.Split(' ');
            for (int i=0; i < outputArrayData.Length; i++)
            {
                Console.WriteLine(outputArrayData[i]);
                
            }
            Console.ReadKey();
        }
    }
}

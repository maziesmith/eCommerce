using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cutting_sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSticks = Convert.ToInt32(Console.ReadLine());
            string strInput = Console.ReadLine();
            List<int> list = new List<int>();
            int min = 0;
            list.AddRange(strInput.Split(' ').Select(x => Convert.ToInt32(x)));

            while(list.Count > 0)
            {
                Console.WriteLine(list.Count());
                min = list.Min();
                list = list.Select(x => x - min).Where(x => x > 0).ToList();
            }
            Console.ReadKey();
        }
    }
}

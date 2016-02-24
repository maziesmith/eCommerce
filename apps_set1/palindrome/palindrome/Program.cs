using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            //js
            //jaisairam
            //om sri maha ganapathaye namaha
            
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            var len = str.Length;
            char[] tempstr = str.ToCharArray();
            Array.Sort(tempstr);
            var j = len - 1;
        

            for (var i=0; i < j; i++)
            {
                if(str[i] == str[j])
                { j--; }
                else
                {
                    return false;

                }

            }

            return true;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome2
{
    //class Program
    //{
    //    static void Main()
    //        // rules of using Main()
    //    {
    //        Console.WriteLine("Enter the string");
    //        string palstr = Console.ReadLine();
    //        int j = palstr.Length - 1;
    //        //variables are declared private and properties are declared public
    //        // variables are by default written as all small letters (ex: name) and properties by first letter capital (ex: Name)

    //        for (int i = 0; i <=j; i++)
    //            // variables declared in for are not accessible outside for()
    //            // under these type of problems where you need several iterations for if and no iterataions required for else,
    //            //have an if and else inside for () and have if within if
    //        {
    //            if (palstr[i] == palstr[j])
    //            {
    //                j--;

    //                if (i >= j)
    //                {
    //                    Console.WriteLine("The given string is a palindrome");
    //                    break;
    //                }

    //            }
    //            else
    //            {
    //                Console.WriteLine("Not a palindrome");
    //                break;
    //            }

    //        }



    //        Console.ReadKey();


    //    }
    //}


    class Program
    {
        static void Main()
            //namespace and class don't have () .... only properties and methods have ()
        {
            Console.WriteLine("Enter the string to verify");
            string checkPalindrome = Console.ReadLine();
            char[] checkPalindromeArray = checkPalindrome.ToCharArray();
            char[] revcheckPalindromeArray = checkPalindromeArray.Reverse().ToArray();
            string revcheckPalindrome = new string(revcheckPalindromeArray);

            //compares two strings
            bool caseignore = checkPalindrome.Equals(revcheckPalindrome, StringComparison.OrdinalIgnoreCase);
            if (caseignore == true)
            {
                Console.WriteLine("Given string is a palindrome");

            }
            else
            {
                Console.WriteLine("It is NOT a palindrome");
            }
            Console.ReadKey();
        }

    }
}

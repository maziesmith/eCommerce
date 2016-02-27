using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //**********************************************
    //        //example
    //        // malayalam
    //        //***********************************************
    //        //logic1
    //        // first element = last element
    //        //console.writeline
    //        //string checkPalindrome = console.readline
    //        //string.length
    //        //for (int i=0; i < string.length ;i++)
    //        //if checkPalindrome[i] == checkPalindrome[j]
    //        //j--
    //        //if i >= j (console.writeline true)
    //        // else (console.writeline false)
    //        //************************************************
    //        //logic2
    //        // reverse array
    //        //bool checkiftrue = str1.Equals(str2 caseignore)
    //        //if checkiftrue == true console.writeline true.. else console.writeline false..
    //        //************************************************

    //        Console.WriteLine("enter a string to verify");
    //        string input = Console.ReadLine();
    //        int inputLength = input.Length;
    //        //classes, variables and properties don't have ().. only methods have ()
    //        int j = inputLength - 1;
    //        //syntax for(condition){action;}.... if(condition){action;}...
    //        //visual icons.. class..looks like branches.. method... looks like cube.. variable.. looks like rectangular box.. property.. looks like a wrench.. namespace..looks like C# in a box
    //        for (int i = 0; i < inputLength; i++)
    //        {
    //            if (input[i] == input[j])
    //            {
    //                j--;
    //                if(i>=j)
    //                {
    //                    Console.WriteLine("YES, input is a Palindrome");
    //                    break;
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("input is NOT a palindrome");
    //                break;
    //            }
    //        }
    //        Console.ReadKey();
    //    }
    //}

    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input to verify");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string revinput = new string(inputArray);
            //enum.. need to learn
            bool checkPalindrome = input.Equals(revinput, StringComparison.OrdinalIgnoreCase);
            if(checkPalindrome == true)
            {
                Console.WriteLine("YES, given input string is a Palindrome");
            }
            else
            {
                Console.WriteLine("input is NOT a palindrome");
            }
            Console.ReadKey();
        }
    }
}

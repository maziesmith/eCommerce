using System;

namespace Palindrome
{
    class PalindromeOrNot
    {
        static void Main()   //compile error: cannot declare instance members in a static class void Main(string inputData)
                                             // has wrong signature to be input point.. static void Main(string inputData)
        {
            Console.WriteLine("Enter input Data");
            string inputData = Console.ReadLine();
            // char[] myInputArray = Console.ReadLine().ToCharArray();  // (q.. correct syntax required)
            char[] myFormatInputData = FormatInputData(inputData);   //q.. you could call this method directly since it is static.. had it not been static, you would have had to create object of the class prior to calling this function.
            bool myPalindromeResult = IsPalindromeOrNot(myFormatInputData);
            FormatOutputData(inputData, myPalindromeResult);
            Console.ReadKey();
        }

        static char[] FormatInputData(string preFormatData)   //q.. is input parameter mandatory to call a method? If yes, how come Main method works even without providing input parameter?
        {
            char[] formattedInputArray = preFormatData.ToCharArray();
            return formattedInputArray;
        }

        static bool IsPalindromeOrNot(char[] arr)
        {
            
            int j = arr.Length - 1;    //arr.Length.. Length of array is a property.. it's not a method..
            for (int i = 0; i < j; i++)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                    //break;   //q.. unreachable code detected..
                }
                else
                { j--; }
            }
            return true;
        }

        static void FormatOutputData(string inputDataInfo, bool resultInfo)
        {
            Console.WriteLine("Palindrome Or Not Result: {0} - {1}", inputDataInfo, resultInfo);
        }


    }
}
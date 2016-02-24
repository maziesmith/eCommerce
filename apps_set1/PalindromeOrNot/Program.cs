//Write code to find if the given string is a palindrome or not


using System;
//q.. s or m.s -- ans.. just System
//q.. what classes are you planning to use for this program
//q.. basic libraries to reference in any program
//q.. how to create custom libraries
//q.. how to plan testing
//q.. how to plan for edge cases

//q.. basic .NET classes present in System namespace
//q.. basic additional namespaces required for solving easy level problems
//q.. naming conventions
//q.. is namespace mandatory for creating dll?
//q.. when to create .exe and when to create .dll library
//q.. any types for namespaces? partial namespaces or anything else?
//q.. class.. public vs partial vs.. etc
//q.. Main() method format..
//q.. Core method IsPalindromeOrNot() format..
//q.. input format..
//q.. output format..
//q.. any extension methods required?
//q.. is this core method IsPalindromeOrNot() already present in .NET library?
//q.. O(n) and space complexity

//q.. readable code and comments
//q.. steps to build,package, deploy..
//q.. what if this needs to be consumed by other programming languages.. web services?
//q.. versioning of this program
//q.. signed key.. security etc..
//q.. required to be placed in GAC?
//q.. Windows app or Web app or mobile app or service or library?

//q.. Algorithm design
//q.. clear ambiguity..
//q.. Edge Cases.. Boundary Condition.. Testing..
//q.. Object Oriented Design for this program..
//q.. why int.. why not long.. similarly.. string vs stringbuilder etc.. tradeoffs..







//namespace PalindromeOrNot
//q.. what is namespace.. naming convention
//mistake.. forgot braces for namespace
//{
    class Program
    {
    //int test;
    //const int testConst = 10;
        static void Main()
        //q.. if you are planning to give input through console, does it required to be mentioned as input parameter in Main() brackets?
        {
        
        //Program testClass = new Program();
        //testClass.test = 12;
        //int testSum = testClass.test + testConst;

            
            Console.WriteLine("Input the string to check if it is a palindrome or not\n");
            string inputString = Console.ReadLine();
            //mistake.. ReadLine was written as Readline
            //mistake.. Array not declared..
            //q.. is array instantiation required with new? or can array be directly assigned after declaration?

            
            Char[] inputArray = inputString.ToCharArray();
            //learn about ToCharArray
            //cannot implicity convert char[] to string[]
            //mistake.. Char.ToStringArray was written
            //q.. identify and memorize important methods..
            Palindrome(inputArray);
            Console.ReadKey();

        }

        static void Palindrome(Char[] arr)
        {
            //mistake.. every item in arr is actually Char.. it's not a String.. hence, Char[] should be used..
            //q.. Array vs Char[] vs String[] vs int[]
            //q.. format in notepad++
            //q.. public or private etc.. void vs int.. 
            //q.. how to code? first complete Main function then algorithm function.. or vice versa
            //q.. notepad++ stop intellisense
            //q.. string or String?

            int arrLength = arr.Length;
            //q.. length or Length? is Length a method or property?

            for (int i = 0; i < (arrLength) / 2; i++)
            {
                if (arr[i] != arr[arrLength - i - 1])
                {
                    Console.WriteLine("NOT a palindrome");
                    break;
                    //q.. break? method or property or what?
                    //q.. break.. breaks from which loop?
                }

                else
                {
                    if (i + 1 >= (arrLength - 1) / 2)
                    {
                        Console.WriteLine("Given string is a palindrome");
                        break;
                    }
                }

            }
            

        }


    }
//}

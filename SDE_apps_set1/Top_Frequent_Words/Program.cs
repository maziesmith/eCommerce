using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Frequent_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of words in wordlist\n");
            int inputargsLength = Convert.ToInt32(Console.ReadLine());
           
            string[] inputargsArray = new string[inputargsLength];
            Console.WriteLine("Enter the words in each line\n");
            for (int m = 0; m < inputargsLength; m++)
            {
                inputargsArray[m] = Console.ReadLine();
            }
            FrequentWords(inputargsLength, inputargsArray);
            Console.ReadKey();
            

        }

        static void FrequentWords(int arrLength,  string[] arr)
        {
            //arr = new Array[arrLength]; wrong syntax
            //arr = new string[arrLength]; instantiation in Main()
            //int arrLength = arr.Length(); can't be invoked without instantiating. So, arrLength should be passed as an input parameter
            string wordName = arr[0];
            //int wordCount = 0;
            int tempCount = 0;
            string tempWord = arr[0];
            Array.Sort(arr);
            var kvpList = new List<KeyValuePair<string, int>>();
            //List<int> wordCountList = new List<int>();



                for (int i = 0; i < arrLength - 1; i++)
                {
                    string prev = arr[i];
                    string curr = arr[i + 1];
                    if (prev == curr)
                    {
                        tempCount++;

                    }
                    else
                    {
                    tempWord = prev;
                    kvpList.Add(new KeyValuePair<string, int>(tempWord, tempCount));

                        //if (tempCount > wordCount)
                        //{
                        //    wordCount = tempCount;
                        //    //Reset Counter
                        //    tempCount = 0;
                        //}
                        
                        
                        //wordCountList.Add(tempCount);
                        //Reset Counter
                        tempCount = 0;
                    }


                }
            kvpList.Sort();
            foreach(var pair in kvpList)
            {
                Console.WriteLine(pair);
            }
            //Console.ReadKey();
                //Console.WriteLine("The {0}th Frequent Word is:{1} \n Frequency is:{2} \n", j, wordName, wordCount);
            }

                      
    }
}

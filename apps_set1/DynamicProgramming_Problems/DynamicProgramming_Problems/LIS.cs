using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming_Problems
{
    class LIS
    {
        static void Main()
        {
            //input the length of array
            Console.WriteLine("Input the length of array");
            int inputArrayLength = Int32.Parse(Console.ReadLine());
            int[] inputArray = new int[inputArrayLength];

            Console.WriteLine("Enter the values of inputArray");

            for(int i=0; i<inputArrayLength; i++)
            {
                inputArray[i] = Int32.Parse(Console.ReadLine());
            }

            DisplayInputArray(inputArray);
            LongestIncreaseSequence( inputArray ,inputArrayLength);


        }

        static void LongestIncreaseSequence(int[] fnLisInputArray, int fnInputArrayLength)
        {
            int curr = 0;
            int prev = 0;
            int tempLength = 0;
            int itemsLength = 0;
            int[] tempValue = new int[fnInputArrayLength];
            int[] itemsValue = new int[fnInputArrayLength];

            //Declare StringBuilder
            //Declare String to assign LIS values to string via stringbuilder

            StringBuilder stbu = new StringBuilder();
            string lisValues = "";

            for(int i=0; i<fnInputArrayLength-1; i++)
            {
                prev = fnLisInputArray[i];
                curr = fnLisInputArray[i + 1];
                int currindex = Array.IndexOf(fnLisInputArray, curr);
                stbu.Append(fnLisInputArray[i].ToString() + ",");

                while (currindex < fnInputArrayLength - 1)
                {
                    if (curr >= prev)
                    {
                        //move both prev & curr
                        //record tempLength & tempValue[]

                        //record values to stringbuilder
                        stbu.Append(curr.ToString() + ",");

                        prev = curr;

                        if (currindex <= fnInputArrayLength - 1)
                        {
                            if (tempLength == 0)
                            {
                                tempLength = 2;
                            }
                            else
                            {
                                tempLength = tempLength + 1;
                            }
                        }
                            currindex = currindex + 1;
                            curr = fnLisInputArray[currindex];

                    }

                    if (curr < prev)
                    {
                        //move only curr
                        //record tempLength & tempValue[]
                            currindex = currindex + 1;
                            curr = fnLisInputArray[currindex];

                    }
                }

                if(tempLength > itemsLength)
                {
                    itemsLength = tempLength;
                    //itemsValue[] = tempValue[];
                    lisValues = stbu.ToString();



                }
                //reset tempLength and stringbuilder
                tempLength = 0;
                stbu.Clear();

            }

            Console.WriteLine("\n output..LIS length is: {0}", itemsLength);
            Console.WriteLine("LIS values are: {0}", lisValues);

            Console.ReadKey();
        }

        static void DisplayInputArray(int[] fnInputArray)
        {
            for(int j=0; j<fnInputArray.Length; j++)
            {
                Console.Write("{0},", fnInputArray[j]);
            }
        }
    }

    public static class Extensions
    {
        public static void Clear(this StringBuilder value)
        {
            value.Length = 0;
            value.Capacity = 0;
        }
    }
}

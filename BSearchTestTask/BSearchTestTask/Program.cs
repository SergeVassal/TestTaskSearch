using System;

namespace BSearchTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBSearchFunc();            
        }

        private static void TestBSearchFunc()
        {
            int[] myArray = {-20,-100,2,54,4,90 };
            int x = 8;

            Array.Sort(myArray);
            int result = BSearch(myArray, x);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("{0}   {1}", i, myArray[i]);                
            }            

            if (result != -1)
            {
                Console.WriteLine("\nArray index after integer {0}: {1}",x,result);
            }
            else
            {
                Console.WriteLine("There's no such array index");
            }
            Console.ReadKey();
        }

        private static int BSearch(int[] sortedArray,int x)
        {
            int result = -1;            

            try
            {
                int minArrayIndex = 0;
                int maxArrayIndex = sortedArray.Length - 1;                

                if (sortedArray[maxArrayIndex] < x)
                {
                    return result;
                }

                while (minArrayIndex <= maxArrayIndex)
                {
                    int midArrayIndex = (minArrayIndex + maxArrayIndex) / 2;                    

                    if (x == sortedArray[midArrayIndex] && midArrayIndex+1<sortedArray.Length)
                    {
                        result = midArrayIndex + 1;
                        break;
                    }
                    else if (midArrayIndex == minArrayIndex)
                    {
                        if (x < sortedArray[midArrayIndex] )
                        {
                            result = midArrayIndex;
                        }
                        else if (x > sortedArray[midArrayIndex] && x< sortedArray[maxArrayIndex])
                        {
                            result = midArrayIndex + 1;
                        }
                        break;
                    }
                    else if (x < sortedArray[midArrayIndex])
                    {
                        maxArrayIndex = midArrayIndex;                        
                    }
                    else if (x > sortedArray[midArrayIndex])
                    {
                        minArrayIndex = midArrayIndex;                        
                    }
                }
                return result;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
                return result;
            }  
        }        
    }
}

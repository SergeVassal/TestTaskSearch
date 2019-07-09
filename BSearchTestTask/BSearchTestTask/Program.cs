using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSearchTestTask
{
    class Program
    {
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
                    Console.WriteLine("Counted middle Min array index {0}", minArrayIndex);
                    Console.WriteLine("Counted middle Mid array index {0}", midArrayIndex);
                    Console.WriteLine("Counted middle Max array index {0}", maxArrayIndex);

                    if (x == sortedArray[midArrayIndex])
                    {
                        result = midArrayIndex + 1;
                        break;
                    }
                    else if (midArrayIndex == minArrayIndex)
                    {
                        if (x < sortedArray[midArrayIndex])
                        {
                            result = midArrayIndex;
                        }
                        else if (x > sortedArray[midArrayIndex])
                        {
                            result = midArrayIndex + 1;
                        }
                        break;
                    }
                    else if (x < sortedArray[midArrayIndex])
                    {
                        maxArrayIndex = midArrayIndex - 1;
                        Console.WriteLine("Max array index {0}", maxArrayIndex);
                    }
                    else if (x > sortedArray[midArrayIndex])
                    {
                        minArrayIndex = midArrayIndex + 1;
                        Console.WriteLine("Min array index {0}", minArrayIndex);
                    }
                }

                return result;
            }
            catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
                return result;
            }            
            
        }

        static void Main(string[] args)
        {
            int[] myArray = {  };
            Array.Sort(myArray);

            for (int i=0;i<myArray.Length;i++)
            {
                Console.WriteLine("{0}  {1}",i,myArray[i]);
            }

            int result = BSearch(myArray, 4);
            
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}

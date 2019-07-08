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
            int minArrayIndex = 0;
            int maxArrayIndex = sortedArray.Length - 1;            
            int result=-1;

            while (minArrayIndex <= maxArrayIndex)
            {
                int midArrayIndex = (minArrayIndex + maxArrayIndex) / 2;
                
                if (x == sortedArray[midArrayIndex])
                {
                    result = midArrayIndex + 1;
                    break;
                }
                else if (midArrayIndex == maxArrayIndex)
                {
                    if (sortedArray[midArrayIndex] == x)
                    {
                        result = midArrayIndex + 1;                        
                    }
                    else if(x<sortedArray[midArrayIndex])
                    {
                        result = midArrayIndex;
                    }
                    break;
                }
                else if (x < sortedArray[midArrayIndex])
                {
                    maxArrayIndex = midArrayIndex - 1;
                }
                else if (x > sortedArray[midArrayIndex])
                {
                    minArrayIndex = midArrayIndex + 1;
                }                
            }           
           
            return result;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 104,102,103,34,8,2,90 };
            Array.Sort(myArray);
            int result = BSearch(myArray, 200);

            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}

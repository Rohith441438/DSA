using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Learn.BinarySearch
{
    public class BinarySearchAlgorithm
    {
        public void ExecuteBinarySearchAlgorithm()
        {
            //input Array an sorted Array in ascending order
            //array = {2,4,7,9,11,12,16,21};
            //target = 9
            //output  = 3
            int[] intArray = { 2, 4, 7, 9, 11, 12, 16 };
            int target = 2;
            Console.WriteLine(OrderAgnosticBinarySearchAlgorithm(intArray, target));

            int[] dscArray = { 76, 56, 12, 4, -3, -7, -377 };
            int newTarget = -377;
            Console.WriteLine(OrderAgnosticBinarySearchAlgorithm(dscArray, newTarget));
        }

        public static int AscendingBinarySearchTarget(int[] intArray, int target)
        {
            int start = 0;
            int end = intArray.Length - 1;
            while(start <= end)
            {
                int mid = start + ((end - start) / 2);
                if(intArray[mid] > target)
                {
                    end = mid - 1;
                }else if(intArray[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public static int DescendingBinarySearchAlgorithm(int[] intArray, int target)
        {
            int start = 0;
            int end = intArray.Length - 1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if(intArray[mid] > target)
                {
                    start = mid + 1;
                }else if(intArray[mid] < target)
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int OrderAgnosticBinarySearchAlgorithm(int[] intArray, int target)
        {
            int start = 0;
            int end = intArray.Length - 1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if(intArray[start] < intArray[end])//Ascending
                {
                    if(intArray[mid] < target)
                    {
                        start = mid + 1;
                    }else if(intArray[mid] > target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                else//Descending
                {
                    if (intArray[mid] > target)
                    {
                        start = mid + 1;
                    }
                    else if (intArray[mid] < target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
            }

            return -1;
        }
    }
}

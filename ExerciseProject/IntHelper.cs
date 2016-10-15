using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    public class IntHelper
    {

        public static string ArrangeNumbersToFormBiggestNumber(List<string> input)
        {
            input.Sort(CustomStringComparator);

            return string.Concat(input);

        }

        private static int CustomStringComparator(string x, string y)
        {
            string s1 = x + y;
            string s2 = y + x;

            return int.Parse(s1) > int.Parse(s2) ? -1 : 1;
        }


        public static int[] RearrangePositiveAndNegative(int[] input)
        {
            int start = -1;
            int end = input.Length - 1;


            for (int j = 0; j <= end; j++)
            {
                if (input[j] <= 0)
                {
                    start++;
                    int temp = input[start];
                    input[start] = input[j];
                    input[j] = temp;
                }
            }

            return input;
        }

        public static void PrintDuplicateInArray(int[] input)
        {
            if (input.Length <= 1)
            {
                return;
            }
            int count = 1;
            int lastDigit = input[0];

            for (int j = 1; j < input.Length; j++)
            {


                if (lastDigit == input[j])
                {
                    count++;
                }
                else
                {
                    count = 1;
                    lastDigit = input[j];
                }

                if (count == 2)
                {
                    Console.Out.WriteLine(lastDigit);
                }
            }
        }


        public static int IndexOfRotatedArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start < end)
            {

                int m = (start + end) / 2;

                if (start - end == 1 || start - end == -1)
                {
                    if (array[start] > array[end])
                    {
                        return array[end];
                    }

                    return array[start];
                }

                if (array[start] > array[m])
                {
                    end = m;
                }
                else
                {
                    start = m + 1;
                }


            }


            return array[start];
        }

        public static int[] RemoveDuplicateFromSortedArray(int[] input)
        {
            if (input == null)
            {
                return null;
            }
            int count = -1;

            int lastvisited = int.MaxValue;
            int i;
            for (i = 0; i < input.Length; i++)
            {
                if (input[i] != lastvisited)
                {
                    count++;
                    input[count] = input[i];
                    lastvisited = input[i];
                }
            }

            int[] retArray = new int[count + 1];
            Array.Copy(input, retArray, count + 1);

            return retArray;
        }


        public static void SubArraySum(int[] arr, int n, int sum)
        {
            // create an empty map
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Maintains sum of elements so far
            int currSum = 0;

            for (int i = 0; i < n; i++)
            {
                // add current element to curr_sum
                currSum = currSum + arr[i];

                // if curr_sum is equal to target sum
                // we found a subarray starting from index 0
                // and ending at index i
                if (currSum == sum)
                {
                    Console.Out.WriteLine("Sum found between indexes "
                         + 0 + " to " + i);
                    return;
                }

                // If curr_sum - sum already exists in map
                // we have found a subarray with target sum
                if (map.ContainsKey(currSum - sum))
                {
                    Console.Out.WriteLine("Sum found between indexes " +
                         (map[currSum - sum] + 1)
                    + " to " + i);
                    return;
                }

                map[currSum] = i;
            }

            // If we reach here, then no subarray exists
            Console.Out.WriteLine("No subarray with given sum exists");
        }

        public static int[] MergeTwoSortedArrays(int[] input1, int[] input2)
        {
            int array1Start = 0, array2Start = 0;
            int array1Len = input1.Length, array2Len = input2.Length;
            int counter = 0;
            int[] retArray = new int[input1.Length + input2.Length];
            while (array1Start < array1Len && array2Start < array2Len)
            {
                if (input1[array1Start] < input2[array2Start])
                {
                    retArray[counter] = input1[array1Start];
                    array1Start++;
                }
                else
                {
                    retArray[counter] = input2[array2Start];
                    array2Start++;
                }
                counter++;
            }

            while (array1Start < array1Len)
            {
                retArray[counter] = input1[array1Start];
                array1Start++;
                counter++;
            }

            while (array2Start < array2Len)
            {
                retArray[counter] = input2[array2Start];
                array2Start++;
                counter++;
            }

            return retArray;


        }

       
        public static int LargeNumber(int number)
        {
            int[] times = new int[10];

            while (number > 0)
            {
                int n = number % 10;
                times[n]++;
                number /= 10;

            }

            int retValue = 0;
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < times[i]; j++)
                {
                    retValue = retValue * 10 + i;
                }
            }
            return retValue;
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TempTest
{
    public class StringHelpers
    {
        public static long StringToInt(string numberasString)
        {
            if (numberasString == null)
            {
                return 0;
            }
            long number = 0;
            int i = 0;

            while (i < numberasString.Length)
            {
                number = number * 10;
                number = number + (numberasString[i++] - '0');

            }

            return number;
        }
        public static char? FindFirstNonRepeatingCharacter(string input)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }


            foreach (var c in input)
            {
                if (dictionary[c] == 1)
                {
                    return c;
                }
            }

            return null;
        }

        public static string RemoveChars(string input, string remove)
        {
            char[] s = input.ToCharArray();
            bool[] flags = new bool[128];

            foreach (char rm in remove)
            {
                flags[rm] = true;
            }

            int src = 0; int dst = 0;
            int len = s.Length;
            while (src < len)
            {
                if (!flags[s[src]])
                {
                    s[dst] = s[src];
                    dst++;
                }
                src++;
            }

            return new string(s, 0, dst);

        }


        public static string ReverseWord(string input)
        {
            char[] i = input.ToCharArray();
            int start = 0;
            int end = i.Length - 1;
            while (start < end)
            {
                var temp = i[end];
                i[end] = i[start];
                i[start] = temp;

                start++;
                end--;
            }

            return new string(i, 0, i.Length);
        }

        public static void ReverseWordChar(char[] i)
        {
            int start = 0;
            int end = i.Length - 1;
            while (start < end)
            {
                var temp = i[end];
                i[end] = i[start];
                i[start] = temp;

                start++;
                end--;
            }
        }

        public static void ReverseWordChar(char[] i, int start, int end)
        {
            while (start < end)
            {
                var temp = i[end];
                i[end] = i[start];
                i[start] = temp;

                start++;
                end--;
            }
        }

        public static void ReverseWordInString(char[] i)
        {
            ReverseWordChar(i);

            int end = 0, len = i.Length;
            while (end < len)
            {
                if (i[end] != ' ')
                {
                    var start = end;

                    while (end < len && i[end] != ' ')
                    {
                        end++;
                    }

                    end--;

                    ReverseWordChar(i, start, end);
                }
                end++;
            }

        }



        public static string FormatString(string input, int i, int j)
        {
            char[] s = input.ToCharArray();
            int start = 0;
            int len = s.Length - 1;

            for (int k = j; k <= len && start <= len; k++)
            {
                s[start++] = input[k];
            }

            for (int l = i + 1; l < j && l <= len && start <= len; l++)
            {
                s[start++] = input[l];
            }

            for (int m = 0; m <= i && m <= len && start <= len; m++)
            {
                s[start++] = input[m];
            }

            return new string(s, 0, len + 1);
        }


        public static void MultiplyTwoNumber(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];
            int s = C.Length - 1;

            for (int j = B.Length - 1; j >= 0; j--)
            {
                int carry = 0;
                int shift = s;
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    int m = A[i] * B[j];
                    int sum = m + C[shift] + carry;
                    int num = sum % 10;
                    int c = sum / 10;
                    C[shift] = num;
                    carry = c;
                    shift--;
                }
                C[shift] = C[shift] + carry;
                s--;
            }
            Console.Out.WriteLine(C);
        }

        public static void PrintMatrix(int[][] array)
        {

            if (array?[0] == null)
            {
                return;
            }

            int m = array.Length;
            int n = array[0].Length;


            bool ltor = true;

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                if (ltor)
                {
                    int j = 0;

                    while (j < n)
                    {
                        Console.Write(" " + array[i][j]);
                        j++;
                    }

                    ltor = false;

                }
                else
                {

                    int j = n - 1;
                    while (j >= 0)
                    {
                        Console.Write(" " + array[i][j]);
                        j--;
                    }

                    ltor = true;
                }
            }




        }
    }
}

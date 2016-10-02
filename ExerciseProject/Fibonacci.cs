using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    public class Fibonacci
    {

        //recursive

        public static int FibRecursive(int value)
        {

            if (value <= 1)
            {
                return 1;
            }
            return FibRecursive(value - 1) + FibRecursive(value - 2);
        }


        public static int FibItr(int value)
        {
            int s1 = 1, s2 = 1;
            if (value <= 1)
            {
                return s1;
            }


            for (int i = 2; i <= value; i++)
            {
                int temp = s1 + s2;
                s1 = s2;
                s2 = temp;
            }

            return s2;
        }

    }
}

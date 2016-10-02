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
    }

}

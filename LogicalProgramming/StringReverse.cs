using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            String Str = "abcdef";
            char[] arr = Str.ToCharArray();
            char[] result = new char[arr.Length];

            for (int i = 0, j = arr.Length; i < arr.Length; i++, j--)
            {
                result[i] = arr[j];
            }

            String NewString = result.ToString();
        }
    }
}

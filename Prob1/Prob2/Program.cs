using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,55555555));
            string string1 = "hi";
            string string2 = "there";
            Console.WriteLine("Before: {0}, {1}", string1, string2);
            RefStrings(ref string1, ref string2);
            Console.WriteLine("After: {0}, {1}", string1, string2);

            Overload("passing a string");

            #region 1. demo of call by value

            Add(21, 33);
            #endregion

            #region 2. demo of call by reference

            RefStrings(ref string1, ref string2);
            #endregion

            #region 3. overloading

            Overload("passing a string");
            #endregion
        }

        static int Add(int x, int y)
        {
            int z = x + y;

            return z;

        }

        public static void RefStrings(ref string string1, ref string
            string2)
        {
            string1 = "okay";
            string2 = "then";
        }

        static void Overload(int x)
        {
            Console.WriteLine("Is an int");
        }

        static void Overload(string y)
        {
            Console.WriteLine("Is a string");
        }

        


    }
}

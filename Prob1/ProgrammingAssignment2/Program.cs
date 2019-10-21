using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1. array of strings

            string[] myNumbers = new string[10] { "one", "two","three",
                "four","five","six","seven","eight","nine","ten" };

            foreach(string number in myNumbers)
            {
                Console.WriteLine("{0}", number);
            }

            #endregion

            #region 2. array of ints

            int[] myInts = new int[10];

            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = i * 10;
                Console.WriteLine("{0}", myInts[i]);
            }





            #endregion

            #region 3. 2-D array

            int twoDArray = 12;

            // Indent column headers
            Console.Write("{0, 4}", null);

            // Write column headers
            for (int x = 1; x <= twoDArray; ++x)
                Console.Write("{0, 4}", x);

            // Write column header seperator
            Console.WriteLine();
            Console.WriteLine("_______________________________________" +
                "_____________");

            // Write the table
            for (int row = 1; row <= twoDArray; ++row)
            {
                // Write the row header
                Console.Write("{0, 4}", row);

                for (int column = 1; column <= twoDArray; ++column)
                {
                    // Write the row values
                    Console.Write("{0, 4}", row * column);
                }
                // Finish the line
                Console.WriteLine();

            }

            #endregion

        }
    }
}

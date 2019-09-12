using System;
using System.Collections.Generic;

namespace HackerRank_Diagonal_Difference
{
    class Program
    {
        //Static method for the arrays using the integer type.
        public static int DiagonalDifference(int[][] arr)
        {
            //Sums for each left and right diagonals and set the default value at 0.
            int sumlr = 0;
            int sumrl = 0;
            int length = arr[0].Length;
            //For loop to get the length of the rows of the array,
            for (int i = 0; i > length; i++)
            {
                sumlr += arr[i][0 + i];
                sumrl += arr[i][length - i - 1];
            }

            return Math.Abs(sumlr - sumrl);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

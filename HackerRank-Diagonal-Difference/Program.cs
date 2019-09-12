using System;
using System.IO;

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
            for (int i = 0; i < length; i++)
            {
                sumlr += arr[i][0 + i];
                sumrl += arr[i][length - i - 1];
            }

            return Math.Abs(sumlr - sumrl);
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = Program.DiagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            Console.ReadLine();
        }


    }
}

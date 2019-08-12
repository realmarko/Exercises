using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise5
    {
        /// <summary>
        /// Print the matrix and get the zeros of the matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns></returns>
        public  Dictionary<int, int> PrintMatrix(int[,] matrix)
        {
            Dictionary<int, int> dZeros = new Dictionary<int, int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                        dZeros.Add(i, j);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            return dZeros;
        }

        /// <summary>
        /// Replace the rows and columns by zeros
        /// </summary>
        /// <param name="matrix">>Matrix</param>
        /// <param name="zeros">Dictionary with the location of the zeros</param>
        public void EvaluateZero(int[,] matrix, Dictionary<int, int> zeros)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (zeros.ContainsKey(i) || zeros.ContainsValue(j))
                        Console.Write(matrix[i, j] * 0 + " ");
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}

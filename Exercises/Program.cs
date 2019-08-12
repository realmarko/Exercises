using Exercises.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1 Addition
            Exercise1 exercise1 = new Exercise1();
            exercise1.Sum();


            //Exercise2 
            Exercise2 exercise2 = new Exercise2();
            //string original = "uno";
            string original = "aabcccccaaa";
            string compressed = exercise2.Compress(original);
            string finalResult = exercise2.EvaluateSize(original, compressed);
            Console.Write(finalResult);
            Console.ReadLine();


            ////Excercise3
            Exercise3 exercise3 = new Exercise3();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] b = { 3, 2, 9, 3, 7, 11, 15, 13, 23, 27, 32, 35, 36, 37 };
            int[] c = { 1, 3, 5, 7, 11, 13, 15, 17, 19, 21, 23, 27, 35, 37 };
            int[] d = { 9, 17, 32, 7, 2, 3, 1, 45, 46, 47, 55, 60, 6, 17 };

            int[] commonNumbers = exercise3.FindCommonElements(a, b, c, d);

            ////Excercise4
            Exercise4 exercise4 = new Exercise4();
            string[] longestwords = exercise4.GetLongestWord("Esto es solo una minima prueba de pero es la prueba");

            //Excercise5
            Exercise5 exercise5 = new Exercise5();
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 0;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Dictionary<int, int> zeros = exercise5.PrintMatrix(matrix);
            exercise5.EvaluateZero(matrix, zeros);

            //Exercise6
            Exercise6 exercise6 = new Exercise6();
            int result = exercise6.Add(10, 8);

            //Exercise7
            Exercise7 exercise7 = new Exercise7();
            exercise7.PrintCombinations(3);
        }
    }
}

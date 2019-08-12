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
            //Exercise1 exercise1 = new Exercise1();
            //exercise1.Sum();


            //Exercise2 
            Exercise2 exercise2 = new Exercise2();
            //string original = "uno";
            string original = "aabcccccaaa";
            string compressed = exercise2.Compress(original);
            string finalResult = exercise2.EvaluateSize(original, compressed);
            Console.Write(finalResult);
            Console.ReadLine();
        }
    }
}

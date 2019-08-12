using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise6
    {
        /// <summary>
        /// Function that receives two numeric parameters(positive integers), adds them and print the result
        /// in the console. You should not use + or any aritmethic operators
        /// </summary>
        /// <param name="number1">Number1 to add</param>
        /// <param name="number2">Number2 to add</param>
        /// <returns></returns>
        public int Add(int number1, int number2)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < number1; i++)
            {
                builder.Append(1);
            }
            for (int i = 0; i < number2; i++)
            {
                builder.Append(1);
            }
            return builder.Length;
        }
    }
}

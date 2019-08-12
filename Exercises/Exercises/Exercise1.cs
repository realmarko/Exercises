using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise1
    {
        public void Sum()
        {
            int result = 0;
            StringBuilder builder = new StringBuilder();

            for (int k = 1; k <= 10; k++)
            {
                int number = 0;
                number = Convert.ToInt32(Math.Pow(-1, k + 1));
                builder.Append(Convert.ToInt32(Math.Pow(-1, k + 1)));
                builder.Append("/" + (2 * k - 1));
                if (number < 0 && k < 10)
                    builder.Append("+");
                result += Convert.ToInt32(Math.Pow(-1, k + 1)) / 2 * k - 1;
            }
            result = result * 4;
            Console.Write(builder);
            Console.ReadLine();
        }
    }
}

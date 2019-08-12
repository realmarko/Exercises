using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise7
    {
        int contador = 0;
        StringBuilder message = new StringBuilder();
        public string PrintCombinations(int number)
        {
            if (contador == number)
                return message.ToString();



            int newNumber = number - contador;
            int restante = number - newNumber;

            print(newNumber, message);
            print(restante, message);

            contador++;
            PrintCombinations(number);




            Console.Write(message);
            Console.ReadLine();
            return message.ToString();
        }

        private void print(int number, StringBuilder message)
        {
            for (int i = 1; i <= number; i++)
            {
                message.Append("(");
            }
            for (int i = 1; i <= number; i++)
            {
                message.Append(")");
            }

        }
    }
}

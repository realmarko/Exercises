using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise2
    {
        public string EvaluateSize(string original, string compressed)
        {
            if (compressed.Length <= original.Length)
                return compressed;
            else
                return original;
        }

        public string Compress(string text)
        {
            StringBuilder result = new StringBuilder();
            char[] arrText = text.ToCharArray();
            char prevLetter = new char();
            int counter = 0;
            foreach (var letter in arrText)
            {

                if (prevLetter != letter)
                {
                    if (counter != 0)
                        result.Append(prevLetter.ToString() + counter.ToString());
                    counter = 1;
                    prevLetter = letter;

                }
                else
                {
                    counter++;
                }
            }
            result.Append(prevLetter.ToString() + counter.ToString());

            return result.ToString();
        }
    }
}

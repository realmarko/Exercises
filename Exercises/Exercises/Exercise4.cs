using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise4
    {


        /// <summary>
        /// function that receive an sentence, return the longest word
        /// if two or more words has the same length they are returned as an array
        /// but can´t return duplicated words
        /// </summary>
        /// <param name="sentence">Sentence to analize</param>
        /// <returns></returns>
        public string[] GetLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');

            int max = 0;
            List<string> alLongest = new List<string>();
            foreach (var word in words)
            {
                if (word.Length > max)
                {

                    max = word.Length;
                    alLongest.Clear();
                    alLongest.Add(word);
                }
                else if (word.Length >= max && !alLongest.Contains(word))
                {
                    alLongest.Add(word);
                }
            }

            return alLongest.ToArray();

        }
    }
}

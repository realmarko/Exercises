using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercises
{
    public class Exercise3
    {
        /// <summary>
        /// Fin the common elements in the arrays
        /// </summary>
        /// <param name="a">First array</param>
        /// <param name="b">Second array</param>
        /// <param name="c">Third array</param>
        /// <param name="d">Fourth array</param>
        /// <returns></returns>
        public int[] FindCommonElements(int[] a, int[] b, int[] c, int[] d)
        {
            IDictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                dictionary[a[i]] = 1;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (dictionary.ContainsKey(b[i]) && dictionary[b[i]] == 1)
                {
                    dictionary[b[i]] = 2;
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                if (dictionary.ContainsKey(c[i]) && dictionary[c[i]] == 2)
                {
                    dictionary[c[i]] = 3;
                }

            }
            for (int i = 0; i < d.Length; i++)
            {
                if (dictionary.ContainsKey(d[i]) && dictionary[d[i]] == 3)
                {
                    dictionary[d[i]] = 4;

                }

            }
            foreach (var item in dictionary.Where(x => x.Value == 4).Select(y => y.Key).ToArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return dictionary.Where(x => x.Value == 4).Select(y => y.Key).ToArray();
        }
    }
}

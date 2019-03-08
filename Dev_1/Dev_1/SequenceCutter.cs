using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_1
{
    public class SequenceCutter
    {
        public static void Find(string inputsequence)
        {
            if (inputsequence.Length < 2)
            {
                Console.WriteLine("Less than 2 symbols!");
                return;
            }
            for (int i = 0, j = 0; i < inputsequence.Length; i++)
            {
                if ((i + 1 < inputsequence.Length && inputsequence[i] == inputsequence[i + 1]) || (i == inputsequence.Length - 1))
                {
                    while (j != i)
                    {
                        int k = i - j;
                            while (k > 0)
                            {
                                Console.WriteLine(inputsequence.Substring(j, k + 1));
                                k--;
                            }
                        j++;
                    }
                    j++;
                }
            }
        }
    }
}
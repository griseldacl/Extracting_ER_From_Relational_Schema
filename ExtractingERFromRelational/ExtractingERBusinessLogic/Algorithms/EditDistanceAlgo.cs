using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic.Algorithms
{
    public static class EditDistanceAlgo
    {
        public static int CalculateEditDistance(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            int[,] table = new int[len1+1, len2+1];
            for(int index1 = 0; index1 <= len1; index1++)
            {
                table[index1, 0] = index1;
            }
            for (int index2 = 0; index2 <= len2; index2++)
            {
                table[0, index2] = index2;
            }

            int diff;
            for(int index1 = 1; index1 <= len1; index1++)
            {
                for(int index2 = 1; index2 <= len2; index2++)
                {
                    diff = word1.ElementAt(index1-1) == word2.ElementAt(index2-1) ? 0 : 1;
                    table[index1, index2] = Math.Min(Math.Min(table[index1 - 1, index2],
                        table[index1, index2 - 1])+1, diff + table[index1 - 1, index2 - 1]);
                }
            }
   
            return table[len1,len2];
        }
    }
}

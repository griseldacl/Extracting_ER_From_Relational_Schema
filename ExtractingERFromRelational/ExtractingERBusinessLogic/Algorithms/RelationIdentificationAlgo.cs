using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic.Algorithms
{
    public static class RelationIdentificationAlgo
    {
        public static List<Tuple<string, List<string>>> CalculateRelations(List<Tuple<string, string>> weakEntities)
        {
            List<Tuple<string, List<string>>> relations = new List<Tuple<string, List<string>>>();


            for(int index = 0;index<weakEntities.Count;index++)
            {
                for (int innerIndex = index + 1; innerIndex < weakEntities.Count; innerIndex++)
                {

                    if (weakEntities.ElementAt(innerIndex).Item1 == weakEntities.ElementAt(index).Item1)
                    {
                        List<string> related = new List<string>();
                        related.Add(weakEntities.ElementAt(innerIndex).Item2);
                        related.Add(weakEntities.ElementAt(index).Item2);

                        Tuple<string, List<string>> relation = new Tuple<string, List<string>>(weakEntities.ElementAt(innerIndex).Item1, related);
                        relations.Add(relation);

                    }
                }
            }

            return relations;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic.Algorithms
{
    public static class WeakEntityIdentificationAlgo
    {
        public static bool IsAContainedInB(List<string> A, List<string> B)
        {
            foreach(string s in A)
            {
                if (B.Contains(s) == false) return false;
            }

            return true;
        }


        public static List<Tuple<string, string>> CalculateWeakEntities(List<Relation> masterList)
        {
            List<Tuple<string, string>> weakEntities = new List<Tuple<string, string>>();

            foreach(Relation rel in masterList)
            {
                // An entity can be weak only if it has at least 2 primayr keys
                if(rel.primaryKeys.Count>1)
                {
                    foreach(Relation rel2 in masterList)
                    {
                        if((rel.primaryKeys.Count > rel2.primaryKeys.Count) &&
                            IsAContainedInB(rel2.primaryKeys, rel.primaryKeys))
                        {
                            Tuple<string, string> weakEntity = new Tuple<string, string>(rel.relationName, rel2.relationName);
                            weakEntities.Add(weakEntity);
                        }
                    }
                }
            }
            return weakEntities;
        }

    }

}

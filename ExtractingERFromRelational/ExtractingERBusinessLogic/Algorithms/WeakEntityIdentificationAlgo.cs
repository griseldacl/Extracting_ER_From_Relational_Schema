using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic.Algorithms
{
    public static class WeakEntityIdentificationAlgo
    {
        public static List<Tuple<string, string>> CalculateWeakEntities(List<Relation> masterList)
        { 
            List<Tuple<string, string>> weakEntities = new List<Tuple<string, string>>();

            for (int outerIndex = 0; outerIndex < masterList.Count; outerIndex++)
            {
                for (int innerIndex = 0; innerIndex < masterList.Count; innerIndex++)
                {
                    if (innerIndex != outerIndex)
                    {
                        Relation outerRel = masterList.ElementAt(outerIndex);
                        Relation innerRel = masterList.ElementAt(innerIndex);

                        if (innerRel.primaryKeys.Count < outerRel.primaryKeys.Count)
                        {
                            bool weakEntityIdentifier = true;
                            foreach (string primaryKey in innerRel.primaryKeys)
                            {
                                if (outerRel.primaryKeys.Contains(primaryKey) == false)
                                {
                                    weakEntityIdentifier = false;
                                }

                            }
                            if (weakEntityIdentifier)
                            {
                                Tuple<string, string> weakEntity = new Tuple<string, string>(outerRel.relationName, innerRel.relationName);
                                weakEntities.Add(weakEntity);
                            }
                        }
                    }


                }
            }


            return weakEntities;
        }
    }

}

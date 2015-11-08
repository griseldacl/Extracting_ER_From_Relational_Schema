using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtractingERBusinessLogic.Algorithms
{
    public static class ForeignKeyMappingAlgo
    { 
        #region Public Static Methods

        public static List<Tuple<string,string,List<string>>> CalculateForeignKeyRelations(List<Relation> masterListRelation)
        {
            List<Tuple<string, string,List<string>>> foreignKeyRelations = new List<Tuple<string, string,List<string>>>();
            // Add code here to calculate the foreign key dependencies
            foreach(Relation rel in masterListRelation)
            {
                foreach(KeyValuePair<string,AttributeType> kp1 in rel.attributeDict)
                {
                    for (int id = masterListRelation.IndexOf(rel) + 1, id < masterListRelation.Count, id++)
                    {
                        foreach(KeyValuePair<string,AttributeType> kp2 in masterListRelation.ElementAt(id).attributeDict)
                        {
                            if (kp1.Equals(kp2))
                            {
                                if (masterListRelation.ElementAt(id).primaryKey.Contains(kp2))
                                    foreignKeyRelations.Add(new Tuple<string, string, List<string>>(rel.relationName, masterListRelation.ElementAt(id),
                                        new List<string>(kp1.Key)));
                            }
                        }

                    }
                }


            return foreignKeyRelations;
        }

        #endregion
    }
}

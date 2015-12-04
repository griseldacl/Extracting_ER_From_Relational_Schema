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


        public static List<Tuple<string, string, string, string>> CalculateForeignKeys(List<Relation> masterListRelation)
        {
            List<Tuple<string, string, string, string>> foreignKeyRelations = new List<Tuple<string, string, string, string>>();

            foreach(Relation rel in masterListRelation)
            {
                // SELF REFERENCE PORTION
               //1. Take the primary Keys and compare with own attributes
               foreach(string primaryKey in rel.primaryKeys)
                {
                    //Go through each of the attributes and see if its duplicated
                    foreach(KeyValuePair<string, AttributeType> attribute in rel.attributeDict)
                    {
                        // The attribute should contain a portion of its name as the primary key
                        if((attribute.Key.Equals(primaryKey) == false)&&
                            (attribute.Key.Contains(primaryKey) == true))
                        {
                            Tuple<string, string, string, string> newTuple = new Tuple<string, string, string, string>(rel.relationName, rel.relationName, primaryKey, attribute.Key);
                            foreignKeyRelations.Add(newTuple);
                        }

                    }
                }

                // For Other Relations
                for (int index = 0; index < masterListRelation.Count; index++)
                {
                    Relation rel2 = masterListRelation.ElementAt(index);
                    if (rel2.Equals(rel)) continue;
                    else
                    {
                        //For each attribute
                        foreach (KeyValuePair<string, AttributeType> attribute in rel.attributeDict)
                        {
                            foreach (string primaryKey in rel2.primaryKeys)
                            {
                                if (attribute.Key.Contains(primaryKey))
                                {
                                    Tuple<string, string, string, string> newTuple = new Tuple<string, string, string, string>
                                        (rel2.relationName, rel.relationName, primaryKey, attribute.Key);

                                    foreignKeyRelations.Add(newTuple);
                                }
                            }

                        }

                    }

                }

            }

            return foreignKeyRelations;

        }



        public static List<Tuple<string,string,List<string>>> CalculateForeignKeyRelations(List<Relation> masterListRelation)
        {
            List<Tuple<string, string,List<string>>> foreignKeyRelations = new List<Tuple<string, string,List<string>>>();
            // Add code here to calculate the foreign key dependencies
            foreach(Relation rel in masterListRelation)
            {
                foreach(KeyValuePair<string,AttributeType> kp1 in rel.attributeDict)
                {
                    for (int id = masterListRelation.IndexOf(rel) + 1; id < masterListRelation.Count; id++)
                    {
                        foreach(KeyValuePair<string,AttributeType> kp2 in masterListRelation.ElementAt(id).attributeDict)
                        {
                            if (kp1.Equals(kp2))
                            {
                                bool success = false;
                                foreach (string primaryKey in masterListRelation.ElementAt(id).primaryKeys)
                                {
                                    if (primaryKey.Contains(kp2.Key))
                                    {
                                        success = true;
                                    }
                                }
                                if (success)
                                {
                                    List<string> foreignKeys = new List<string>();
                                    foreignKeys.Add(kp1.Key);
                                    foreignKeyRelations.Add(new Tuple<string, string, List<string>>
                                        (rel.relationName, masterListRelation.ElementAt(id).relationName, foreignKeys));
                                }
                            }
                        }
                    }
                }
                
            }

            return foreignKeyRelations;
        }

        #endregion
    }
}

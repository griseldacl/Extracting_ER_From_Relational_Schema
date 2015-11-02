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
        
        public static List<Tuple<string,string>> CalculateForeignKeyRelations(List<Relation> masterListRelation)
        {
            List<Tuple<string, string>> foreignKeyRelations = new List<Tuple<string, string>>();
            // Add code here to calculate the foreign key dependencies 


            //not working: It is skipping line string PK and it is not entering the foreach loop
            //string PK = null;
            //foreach (Relation rel in masterListRelation)
            //{
            //    for (int i = 0; i <= masterListRelation.Count(); i++)
            //    {
            //        PK = masterListRelation.ElementAt(i).primaryKey;   //PK is not being updated
            //    }        
            //}

            //working
            string[] arr = new string[masterListRelation.Count()];
            
            for (int i = 0; i <= masterListRelation.Count(); i++)
            {
                arr[i] = masterListRelation.ElementAt(i).primaryKey;

                for (int j = 1; j <= masterListRelation.Count(); j++)
                {
                    if (masterListRelation.ElementAt(j).attributeDict.ContainsKey(arr[i]))
                    {
                        foreignKeyRelations.Add(masterListRelation.ElementAt(i).relationName, masterListRelation.ElementAt(j).relationName, arr[i]);
                    }
                }

            }

            return foreignKeyRelations;
        }

        #endregion
    }
}

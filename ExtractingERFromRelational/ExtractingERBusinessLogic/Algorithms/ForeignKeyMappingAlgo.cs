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


            int index = 1;
            int count = masterListRelation.Count();
            string pk = masterListRelation.ElementAt(1).primaryKey;


            foreach (Relation rel in masterListRelation)
            {
                
                
            }

            return foreignKeyRelations;
        }

        #endregion
    }
}

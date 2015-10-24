using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingERBusinessLogic
{
    public class Relation
    {
        #region Variables

        public string relationName;
        public string primaryKey;
        public Dictionary<string, Enums.AttributeType> attributeDict;

        #endregion

        #region Constructor

        public Relation()
        {
            relationName = string.Empty;
            primaryKey = string.Empty;
            attributeDict = new Dictionary<string, Enums.AttributeType>();
        }

        #endregion

        #region Public Methods

        #endregion

    }
}

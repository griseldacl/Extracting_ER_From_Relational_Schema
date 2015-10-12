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

        private string _relationName;
        private Dictionary<string, Enums.AttributeType> _attributeDict;

        #endregion

        #region Constructor

        public Relation()
        {
            _relationName = string.Empty;
            _attributeDict = new Dictionary<string, Enums.AttributeType>();
        }

        #endregion

        #region Public Methods

        #endregion

    }
}

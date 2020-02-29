using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConceptApp
{
    class SqlParam
    {
        public string column { get; set; }
        public SqlDbType type { get; set; }
        public object value { get; set; }

        public SqlParam(string _column, SqlDbType _type, object _value)
        {
            column = _column;
            type = _type;
            value = _value;
        }
    }
}

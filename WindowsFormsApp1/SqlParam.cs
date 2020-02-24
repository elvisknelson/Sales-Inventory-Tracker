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
        string column { get; set; }
        SqlDbType type { get; set; }
        string value { get; set; }

        public SqlParam(string _column, SqlDbType _type, string _value)
        {
            column = _column;
            type = _type;
            value = _value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp
{
    public static class Utility
    {
        public static bool IsValidInt(string str)
        {
            bool result;
            int parseResult;

            result = int.TryParse(str, out parseResult);
            return result;
        }

        public static bool IsValidDateTime(string str)
        {
            bool result;
            DateTime parseResult;

            result = DateTime.TryParse(str, out parseResult);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptApp
{
    public static class Utility
    {
        public static bool IsValidInt(string par)
        {
            bool result;
            int parseResult;

            result = int.TryParse(par, out parseResult);

            return result;
        }
    }
}

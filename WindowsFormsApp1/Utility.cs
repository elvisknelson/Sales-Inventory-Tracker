using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Utility
    {
        public static bool IsValid(string str)
        {
            bool result = false;
            int parseResult;

            if (str.Length > 0 && int.TryParse(str, out parseResult))
            {
                result = true;
            }

            return result;
        }
    }
}

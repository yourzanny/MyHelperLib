using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelperLib
{
    public static class MyExtensionMethods
    {
        public static bool Equals(this string comparingStr, string comparedStr, bool ignoreCase)
        => ignoreCase ? comparingStr.ToLower().Equals(comparedStr.ToLower()) : false;
    }
}
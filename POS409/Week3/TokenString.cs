using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class TokenString
    {
        public static string[] SplitString(string strValue, char[] delim)
        {
            return strValue.Split(delim);
        }
    }
}

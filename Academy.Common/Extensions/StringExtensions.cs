using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsABC(this string value)
        {
            return value.Contains("ABC");
        }

        public static string ToNormalized(this string value)
        {
            return value.Replace("$", "").Replace("&", "").Replace("%", "");
        }
    }
}

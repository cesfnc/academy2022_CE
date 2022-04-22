using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Helpers
{
    public static class ResultHelper
    {
        public static string GetEsito(int a, int b)
        {
            string result = string.Empty; //equivale a ""
            if (a == b)
            {
                //pareggio
                result = "X";
            }
            else if (a > b)
            {
                result = "1";
            }
            else
            {
                result = "2";
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace IUERM_RRS.Helpers
{
    public static class StringHelper
    {
        public static string GetStringWrapped(this string s, int len)
        {
            if (!string.IsNullOrEmpty(s))
            {
                StringBuilder sb = new StringBuilder(s);
                int x = sb.Length / len;
                for (int i = 1; i <= x; i++)
                {
                    sb.Insert((len * i) + i - 1, "<br/>");
                }
                s = sb.ToString();
            }
            return s;
        }
    }
}
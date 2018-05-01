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

        public static string ReplaceCustom(this string s, string oldVal)
        {
            StringBuilder sb = new StringBuilder(s);
            if (!string.IsNullOrEmpty(s))
            {
                sb.Insert(0,"*");
                sb.Replace(oldVal, "</br>*");
            }
            return sb.ToString();
        }

        public static string ShortTo(this string s, int number)
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (s.Length > number)
                    s = s.Substring(0, number) + "...";
            }
            return s;
        }
    }
}
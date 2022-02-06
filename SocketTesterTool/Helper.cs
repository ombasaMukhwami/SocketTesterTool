using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketTesterTool
{
    public static class Helper
    {
        public static string ToHex(this string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in input)
                stringBuilder.AppendFormat("{0:X2}", (object)(int)ch);
            return stringBuilder.ToString().Trim();
        }
    }
}

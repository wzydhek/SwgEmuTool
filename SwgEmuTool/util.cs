using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.IO;
using System.Net;
using System.Net.Http;

namespace SwgEmuTool
{
    public static class util
    {
        public static string GetWebString(string url)
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            return s;
        }

        public static bool IsNumeric(this string value)
        {
            int i = 0;
            if (int.TryParse(value, out i))
                return true;
            return false;
        }
    }
}

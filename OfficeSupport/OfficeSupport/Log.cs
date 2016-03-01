using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OfficeSupport
{
    class Log
    {
        public static void Write(string pathFile, string strLog)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(strLog);
            File.AppendAllText(pathFile, sb.ToString());
            sb = null;
        }
    }
}

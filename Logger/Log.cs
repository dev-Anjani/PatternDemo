using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Log : ILog
    {
        private int Counter = 0;
        private Log()
        { Counter++; }

        private static Lazy<Log> instance = new Lazy<Log>(()=>new Log());
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string message)
        {
            string fileName = string.Format($"{"Exception"}_{Counter}.log");
            string logFilePath = string.Format($@"{AppDomain.CurrentDomain.BaseDirectory}{fileName}");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}

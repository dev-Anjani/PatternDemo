using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private Singleton() { counter++; }

        ////Lazy Loading ... but problem with multiple thread
        //private Singleton instance = null;

        //public Singleton GetInstance
        //{
        //    get
        //    {
        //        if (instance == null) instance = new Singleton(); 
        //        return instance;
        //    }
        //}


        ////Eager Loading ... but problem with multiple thread
        //private Singleton instance = new Singleton();

        //public Singleton GetInstance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        //Eager Loading 
        private static Lazy<Singleton> instance = new Lazy<Singleton>();

        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void Logger(string msg)
        {
            string fileName = string.Format($"{"Exception"}_{DateTime.Now}.log");
            string logFilePath = string.Format($@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(msg);

            using (StreamWriter writer = new StreamWriter(logFilePath,true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
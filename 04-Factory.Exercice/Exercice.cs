using System;
using System.Collections.Generic;

namespace _04_Factory.Exercice
{
    
    public class XmlLogger: ILogger
    {
        public string Log(string monLog)
        {
            return "<log>" + monLog + "</log>";
        }
    }
    
    public class JsonLogger: ILogger
    {
        public string Log(string monLog)
        {
            return "{Log:'"+ monLog +"'}";
        }
    }

     public interface ILogger
    {
        string Log(string monLog);
    }

     public abstract class Logger
     {
         public abstract string Log(string monLog);

         public static ILogger Create(LoggerType type)
         {
             switch (type)
             {
                 case LoggerType.Xml:
                     return new XmlLogger();
                 case LoggerType.Json:
                     return new JsonLogger();
                 default:
                     throw new ArgumentOutOfRangeException(nameof(type), type, null);
             }
         }
     }

     public enum LoggerType
     {
         Xml, Json
     }
}

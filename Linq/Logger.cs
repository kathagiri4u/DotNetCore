using System;
using System.Linq;

namespace Linq{
      
    public static class Logger{

        public static Action<string> WriteMessage;          
        public static Severity LogLevel{get;set;} = Severity.Warning;

        public static void LogMessage(Severity s, string component, string msg)
        {

            if(s < LogLevel)
                return;

            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            WriteMessage.Invoke(outputMsg);
        }

    }
}
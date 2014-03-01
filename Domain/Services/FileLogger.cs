using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FileLogger : ILogger
    {
        public string LogFilePath { get; set; }

        public LogLevel Level { get; set; }

        public FileLogger()
        {
            LogFilePath = "FileLog.log";
            Level = LogLevel.Info;
        }
        
        public void Log(string message)
        {
            if (Level >= LogLevel.Info)
                WriteToLog(message);
        }
        private void WriteToLog(string message)
        {
            throw new NotImplementedException();
        }


        public void Write(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(string message, int threadid)
        {
            throw new NotImplementedException();
        }
    }
}

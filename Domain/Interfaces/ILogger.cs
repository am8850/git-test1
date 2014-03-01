using System;
namespace Domain.Interfaces
{
    interface ILogger
    {
        void Log(string message);
        void Write(string message);
        void Log(string message, int threadid);
    }
}

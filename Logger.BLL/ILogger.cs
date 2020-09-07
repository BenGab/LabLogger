using System;

namespace Logger.BLL
{
    public interface ILogger
    {
        void AddLogMethod(Action<string> logFunction);

        void Log(string message);
    }
}

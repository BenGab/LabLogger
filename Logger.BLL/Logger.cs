using System;

namespace Logger.BLL
{
    public class Logger : ILogger
    {
        private Action<string> logMethods;

        public void AddLogMethod(Action<string> logFunction)
        {
            logMethods += logFunction;
        }

        public void Log(string message)
        {
            logMethods?.Invoke($"[{DateTime.UtcNow}] - message");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Logger.BLL
{
    public class Logger : ILogger
    {
        private Action<string> logMethods;
        private ICollection<string> logentries;

        public void AddLogMethod(Action<string> logFunction)
        {
            logMethods += logFunction;
            logentries = new List<string>();
        }

        public ICollection<string> Filter(Func<string, bool> condition)
        {
            List<string> result = new List<string>();

            foreach(var item in logentries)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public void Log(string message)
        {
            string msg = $"[{DateTime.UtcNow}] - {message}";
            logentries.Add(msg);
            logMethods?.Invoke(msg);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Logger.BLL
{
    public interface ILogger
    {
        void AddLogMethod(Action<string> logFunction);

        void Log(string message);

        ICollection<string> Filter(Func<string, bool> condition);
    }
}

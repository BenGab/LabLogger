using Logger.BLL;
using System;
using System.IO;

namespace LabLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger.BLL.Logger();
            logger.AddLogMethod(Console.WriteLine);
            logger.AddLogMethod(x => Console.WriteLine(x));
            logger.AddLogMethod(x =>
            {
                using(StreamWriter writer = new StreamWriter("log.txt", true))
                {
                    writer.WriteLine(x);
                }
            });

            logger.Log("Sample log message");
        }
    }
}

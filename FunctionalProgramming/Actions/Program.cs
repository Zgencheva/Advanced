using System;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> logger = LogInfo;
            logger("Pesho");
            logger("Dimitrichko");
            Action noParams = LogInfoNoParams;
        }

        static void LogInfo(string name)
        {
            Console.WriteLine($"Say my name {name}");
        }

        static void LogInfoNoParams()
        {
            Console.WriteLine($"Say my name");
        }
    }
}

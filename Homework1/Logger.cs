namespace Homework1
{
    public class Logger
    {
        private static string _logFilePath;

        static Logger()
        {
            _logFilePath = "C:\\Users\\repos";
        }

        public static void WriteLog(string log)
        {
            const string LogSeparator = "> ";

            Console.WriteLine(_logFilePath + LogSeparator + log);
        }
    }
}

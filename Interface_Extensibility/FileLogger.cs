using System.IO;

namespace Interface_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void logError(string message)
        {
            Log(message, "ERROR");
        }
        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
        public void Log(string message, string message_type)
        {
            /*StreamWriter uses a file resource that is not managed by the CLR (Common Language Runtime)
             * This means we need to dispose of that resource when we are done using it. The easiest way
             * to do this is by wrapping the StreamWriter in a using block like done here.
             */
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine($"{message_type}: {message}");
            }
        }
    }
}

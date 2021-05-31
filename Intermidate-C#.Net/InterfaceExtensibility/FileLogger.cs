using System.IO;

namespace InterfaceExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }


        public void LogError(string error)
        {
            Log(error, "ERROR");
        }

        public void LogInfo(string info)
        {
            Log(info, "INFO");
        }

        public void Log(string message, string type)
        {
            using var streamfile = new StreamWriter(_path, true);
            streamfile.WriteLine($"{type}: {message}");
        }
    }
}
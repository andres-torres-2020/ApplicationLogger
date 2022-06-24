namespace ApplicationLogger
{
    public class Logger : ILogger
    {
        string LogFileName;
        SimpleLogger LoggerInstance;
        public Logger(string logFileName)
        {
            SetLogFile(logFileName);
            SetLogger();
        }
        public void SetLogFile(string logFileName)
        {
            LogFileName = logFileName.Trim();
        }
        private void SetLogger()
        {
            LoggerInstance = new SimpleLogger(LogFileName);
        }
        public void Log(string message)
        {
            LoggerInstance.Log(message);
        }
    }
}
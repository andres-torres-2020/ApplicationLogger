namespace ApplicationLogger
{
    public interface ILogger
    {
        void SetLogFile(string logFileName);
        void Log(string message);
    }
}
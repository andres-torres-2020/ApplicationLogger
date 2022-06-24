using System;
using System.IO;
using ApplicationLogger;

public class SimpleLogger
{
    string LogFileName;
    StreamWriter LogStream;
    
    public SimpleLogger(string logFileName)
    {
        this.LogFileName = logFileName;
        this.LogStream = this.InitializeLog();
    }
    private StreamWriter InitializeLog()
    {
        return new StreamWriter(LogFileName, true);
    }
    public void Log(string  message)
    {
        string logEntry = $"{DateTime.Now.ToString("s")} {message}";
        if (message.Length > 0)
        {
            this.LogStream.WriteLine(logEntry);
            this.LogStream.Flush();
        }
        Console.WriteLine(logEntry);
    }
}

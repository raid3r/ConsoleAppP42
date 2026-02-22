using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.LogsExample;

public static class AppLogger
{
    private static MyLogger _logger = new MyLogger();
    public static LogLevel LogLevel
    {
        get => _logger.Level;
        set => _logger.Level = value;
    }
    public static void Debug(string message) => _logger.Debug(message);
    public static void Info(string message) => _logger.Info(message);
    public static void Warn(string message) => _logger.Warn(message);
    public static void Error(string message) => _logger.Error(message);
    public static void Critical(string message) => _logger.Critical(message);
}

public enum LogLevel
{
    Debug = 0,
    Info = 1,
    Warning = 2,
    Error = 3,
    Critical = 4
}

public class MyLogger
{
    public LogLevel Level { get; set; } = LogLevel.Debug;
    public void Debug(string message)
    {
        if (Level > LogLevel.Debug) return;
        Log("DEBUG", message);
    }

    public void Info(string message)
    {
        if (Level > LogLevel.Info) return;
        Log("INFO", message);
    }

    public void Warn(string message)
    {
        if (Level > LogLevel.Warning) return;
        Log("WARNING", message);
    }
    public void Error(string message)
    {
        if (Level > LogLevel.Error) return;
        Log("ERROR", message);

    }

    public void Critical(string message)
    {
        if (Level > LogLevel.Critical) return;
        Log("CRITICAL", message);
    }


    private void Log(string level, string message)
    {
        var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}{Environment.NewLine}";
        Console.Write(logMessage);
        File.AppendAllText("log.txt", logMessage, Encoding.UTF8);
    }
}

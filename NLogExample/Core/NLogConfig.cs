using NLog;
using NLog.Targets;

namespace ValueOfObjects.Core;

public class NLogConfig
{
    public void Config()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Targets where to log to: File and Console
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
        var logfile = new NLog.Targets.FileTarget("logfile")
        {
            FileName = "file.txt",
            Layout = "${longdate}|${level:uppercase=true}|${logger}|${threadid}|${message}|${exception:format=tostring}"
        };

        // Rules for mapping loggers to targets            
        config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
        config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);

        // Apply config           
        LogManager.Configuration = config;
    }

    public void ColoredConfig()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Создание консольного таргета
        var consoleTarget = new ColoredConsoleTarget();
        config.AddTarget("console", consoleTarget);

        // Установка цвета для разных уровней логирования
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Trace",
            ConsoleOutputColor.White, ConsoleOutputColor.Black));
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Debug",
            ConsoleOutputColor.Gray, ConsoleOutputColor.Black));
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Info",
            ConsoleOutputColor.Green, ConsoleOutputColor.Black));
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Warn",
            ConsoleOutputColor.Yellow, ConsoleOutputColor.Black));
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Error",
            ConsoleOutputColor.Red, ConsoleOutputColor.Black));
        consoleTarget.RowHighlightingRules.Add(new ConsoleRowHighlightingRule("level == LogLevel.Fatal",
            ConsoleOutputColor.DarkRed, ConsoleOutputColor.Black));

        // Rules for mapping loggers to targets            
        config.AddRule(LogLevel.Trace, LogLevel.Fatal, consoleTarget);

        // Применение конфигурации
        LogManager.Configuration = config;
    }
}
// TODO: define the 'LogLevel' enum

public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string nivel = "";
        // Usamos 'logLine' con L mayúscula
        int indice = logLine.IndexOf(":"); 

        for (int i = 0; i < indice; i++)
        {
            if (logLine[i] != '[' && logLine[i] != ']')
            {
                nivel += logLine[i];
            }
        }

        nivel = nivel.Trim();

        return nivel switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
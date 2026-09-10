static class LogLine
{
    public static string Message(string logLine)
    {
        string result = logLine.Replace("[error]: ", "", StringComparison.OrdinalIgnoreCase).Replace("[warning]: ", "", StringComparison.OrdinalIgnoreCase).Replace("[info]: ", "", StringComparison.OrdinalIgnoreCase).Trim();
                                                                                                                                                                    
        return result;
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.ToLower().Contains("[error]: ")){
            return "error";
        }
        else if (logLine.ToLower().Contains("[warning]: ")){
            return "warning";
        }
        else if (logLine.ToLower().Contains("[info]: ")){
            return "info";
        }
        else{
            return "";
        }
    }

    public static string Reformat(string logLine)
    {
        string mensaje = Message(logLine);
        string loglevel = LogLevel(logLine);

        return $"{mensaje} ({loglevel})";
    }
}

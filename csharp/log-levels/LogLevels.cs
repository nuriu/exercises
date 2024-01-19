using System;

public static class LogLine
{
    public static string Message(string logLine) => logLine[(logLine.IndexOf(':') + 1)..].Trim();

    public static string LogLevel(string logLine) => logLine[1..(logLine.IndexOf(']'))].ToLowerInvariant();

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}

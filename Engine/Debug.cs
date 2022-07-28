using RZEngine.Core.Debugging;

namespace RZEngine
{
    public class Debug
    {

#nullable enable

        public static void Log(object? value)
        {
            string? log = (value != null)
                ? value.ToString()
                : "";

            if (Logger.Instance != null)
                Logger.Instance.Write(log);

            System.Diagnostics.Debug.WriteLine(log);
        }

        public static void Log(string? message)
        {
            string? log = (message != null)
                ? message
                : "";

            if (Logger.Instance != null)
                Logger.Instance.Write(log);

            System.Diagnostics.Debug.WriteLine(log);
        }

        public static void Log(object? value, string? category)
        {
            string? log = (value != null)
                ? value.ToString()
                : "";

            if (Logger.Instance != null)
                Logger.Instance.Write(log);

            System.Diagnostics.Debug.WriteLine(log, category);
        }

        public static void Log(string format, params object?[] args)
        {
            System.Diagnostics.Debug.WriteLine(format, args);
        }

        public static void Log(string? message, string? category)
        {
            string? log = (message != null)
                ? message
                : "";

            if (Logger.Instance != null)
                Logger.Instance.Write(log);

            System.Diagnostics.Debug.WriteLine(log, category);
        }

#nullable disable

    }
}

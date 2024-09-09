using AltV.Net.ColoredConsole;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static void LogColored(string message) => CoreImpl.LogColored(message);
        public static void LogColored(ColoredMessage message) => CoreImpl.LogColored(message.ToString());
    }
}
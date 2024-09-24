using System;
using System.Text;

namespace AltV.Net
{
    public static partial class Alt
    {
        private const string HourWithZero = "[0";
        private const string HourWithoutZero = "[";

        private const string NumberWithZero = ":0";
        private const string NumberWithoutZero = ":";

        private const string Ending = "] ";

        public static void LogFast(string message)
        {
            var dateTimeNow = DateTime.Now;
            var hour = dateTimeNow.Hour;
            var minute = dateTimeNow.Minute;
            var second = dateTimeNow.Second;
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(hour < 10 ? HourWithZero : HourWithoutZero);

            stringBuilder.Append(hour);

            stringBuilder.Append(minute < 10 ? NumberWithZero : NumberWithoutZero);

            stringBuilder.Append(minute);

            stringBuilder.Append(second < 10 ? NumberWithZero : NumberWithoutZero);

            stringBuilder.Append(second);
            stringBuilder.Append(Ending);

            stringBuilder.Append(message);

            Console.WriteLine(stringBuilder.ToString());
        }

        /// <summary>
        /// Logging a message as Information about something
        /// </summary>
        /// <param name="message">a message</param>
        public static void LogInfo(string message)
        {
            Alt.CoreImpl.LogInfo(message);
        }

        /// <summary>
        /// Logging a message if Debug-Mode is enabled
        /// </summary>
        /// <param name="message">a message</param>
        public static void LogDebug(string message)
        {
            Alt.CoreImpl.LogDebug(message);
        }

        /// <summary>
        /// Logging a message as Warning about something maybe being wrong, but not being very important
        /// </summary>
        /// <param name="message"> a message</param>
        public static void LogWarning(string message)
        {
            Alt.CoreImpl.LogWarning(message);
        }

        /// <summary>
        /// Logging a message as Error about something going very wrong, which needs immediate action
        /// </summary>
        /// <param name="message">a message</param>
        public static void LogError(string message)
        {
            Alt.CoreImpl.LogError(message);
        }
    }
}

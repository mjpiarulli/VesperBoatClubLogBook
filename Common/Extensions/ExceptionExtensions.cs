using System;
using System.Text;

namespace Common.Extensions
{
    public static class ExceptionExtensions
    {
        public static string ToMoreBetterString(this Exception e)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Exception Message: {e.Message}");
            sb.AppendLine();
            sb.AppendLine($"Inner Exception: {e.InnerException}");
            sb.AppendLine();
            sb.AppendLine($"Stack Trace: {e.StackTrace}");

            return sb.ToString();
        }
    }
}

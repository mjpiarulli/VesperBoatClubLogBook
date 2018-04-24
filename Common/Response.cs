using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Extensions;

namespace Common
{
    public class Response
    {
        public Response()
        {
            Success = true;
            LogMessages = new List<string>();
            WarningMessages = new List<string>();
            ErrorMessages = new List<string>();
            ExceptionMessages = new List<string>();
        }

        public bool Success { get; set; }
        public bool HasMessages => LogMessages.Any() || WarningMessages.Any() || ErrorMessages.Any() || ExceptionMessages.Any();
        public bool HasLogMessages => LogMessages.Any();
        public bool HasWarningMessages => WarningMessages.Any();
        public bool HasErrorMessages => ErrorMessages.Any();
        public bool HasExceptionMessages => ExceptionMessages.Any();
        public List<string> LogMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<string> ExceptionMessages { get; set; }

        public void AddLogMessage(string message)
        {
            LogMessages.Add(message);
        }

        public string GetAllLogMessages()
        {
            return HasLogMessages ? string.Join("\n\r", LogMessages) : string.Empty;
        }

        public void AddWarningMessage(string message)
        {
            WarningMessages.Add(message);
        }

        public string GetAllWarningMessages()
        {
            return HasWarningMessages ? string.Join("\n\r", WarningMessages) : string.Empty;
        }

        public void AddErrorMessage(string message)
        {
            Success = false;
            ErrorMessages.Add(message);
        }

        public string GetAllErrorMessages()
        {
            return HasErrorMessages ? string.Join("\n\r", ErrorMessages) : string.Empty;
        }

        public void AddExceptionMessage(string message)
        {
            Success = false;
            ExceptionMessages.Add(message);
        }

        public void AddExceptionMessage(Exception e)
        {
            AddExceptionMessage(e.ToMoreBetterString());
        }

        public string GetAllExceptionMessages()
        {
            return HasExceptionMessages ? string.Join("\n\r", ExceptionMessages) : string.Empty;
        }

        public string GetAllMessages()
        {
            var sb = new StringBuilder();
            if (HasExceptionMessages)
            {
                sb.AppendLine("Exception Messages:");
                sb.AppendLine(string.Join("\n\r", ExceptionMessages));
                sb.AppendLine();
            }
            if (HasErrorMessages)
            {
                sb.AppendLine("Error Messages:");
                sb.AppendLine(string.Join("\n\r", ErrorMessages));
                sb.AppendLine();
            }
            if (HasWarningMessages)
            {
                sb.AppendLine("Warning Messages:");
                sb.AppendLine(string.Join("\n\r", WarningMessages));
                sb.AppendLine();
            }
            if (HasLogMessages)
            {
                sb.AppendLine("Log Messages:");
                sb.AppendLine(string.Join("\n\r", LogMessages));
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
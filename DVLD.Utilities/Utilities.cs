using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace DVLD.Utilities
    
{
    /// <summary>
    /// Provides functionality for logging messages to the Windows Event Log.
    /// </summary>
    /// <remarks>The <see cref="Logger"/> class allows applications to log informational, warning, and error
    /// messages to the Windows Event Log. Before logging messages, the <see cref="Configure(string, string)"/> method
    /// must be called to set up the event source and log name. If the specified event source does not exist, it will be
    /// created automatically. <para> This class is designed for static usage and does not require instantiation.
    /// </para> <para> Note: Ensure the application has appropriate permissions to write to the Windows Event Log.
    /// </para></remarks>
    public static class clsLogger
    {
        private static string _SourceName;
        private static string _LogName;

        /// <summary>
        /// Configures the event log source and log name for the application.
        /// </summary>
        /// <remarks>If the specified event log source does not exist, it will be created and associated
        /// with the specified log name. This method is designed to ensure the event log source is properly set up for
        /// logging purposes.</remarks>
        /// <param name="SourceName">The name of the event log source to configure. Defaults to "DVLD" if not specified.</param>
        /// <param name="LogName">The name of the event log to associate with the source. Defaults to "Application" if not specified.</param>
        /// 
        public static void Configure(string SourceName = "DVLD", string LogName = "Application")
        {
            _SourceName = SourceName;
            _LogName = LogName;

            try
            {
                if (!EventLog.SourceExists(_SourceName))
                {
                    EventLog.CreateEventSource(_SourceName, _LogName);
                    LogInfo($"Created new EventLog source: {_SourceName}");
                }
            }
            catch (Exception)
            {
                // intentionally left blank
            }
        }
        /// <summary>
        /// Logs an informational message to the event log.
        /// </summary>
        /// <remarks>This method writes the specified message to the event log with an entry type of  <see
        /// cref="System.Diagnostics.EventLogEntryType.Information"/>. Ensure that the application  has the necessary
        /// permissions to write to the event log.</remarks>
        /// <param name="message">The message to be logged. Cannot be null or empty.</param>
        public static void LogInfo(string message) => Log(message, EventLogEntryType.Information);
        /// <summary>
        /// Logs a warning message to the event log.
        /// </summary>
        /// <remarks>This method writes the specified message to the event log with a warning severity.
        /// Ensure that the application has the necessary permissions to write to the event log.</remarks>
        /// <param name="message">The warning message to log. Cannot be null or empty.</param>
        public static void LogWarning(string message) => Log(message, EventLogEntryType.Warning);
        /// <summary>
        /// Logs an error message to the event log.
        /// </summary>
        /// <remarks>This method writes the specified error message to the event log using the <see
        /// cref="EventLogEntryType.Error"/> type. Ensure that the application has the necessary permissions to write to
        /// the event log.</remarks>
        /// <param name="message">The error message to log. Cannot be null or empty.</param>
        public static void LogError(string message) => Log(message, EventLogEntryType.Error);
        /// <summary>
        /// Writes a log entry to the Windows Event Log with the specified message and entry type.
        /// </summary>
        /// <remarks>If the <paramref name="message"/> is null, empty, or consists only of whitespace, the
        /// method does nothing. The log entry includes a timestamp in the format "yyyy-MM-dd HH:mm:ss" prepended to the
        /// message.</remarks>
        /// <param name="message">The message to log. Cannot be null, empty, or consist solely of whitespace.</param>
        /// <param name="type">The type of event log entry to create. This determines the severity level of the log entry.</param>
        public static void Log(string message, EventLogEntryType type)
        {
            if (string.IsNullOrWhiteSpace(message)) return;

            try
            {
                string fullMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
                EventLog.WriteEntry(_SourceName, fullMessage, type);
            }
            catch (Exception)
            {
                // intentionally left blank
            }
        }
    }

    public static class clsSecurity
    {

        private static string _input;

      public  static string ComputeHash(string input)
        {
            _input = input;

            if (string.IsNullOrEmpty(_input)) return "";
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm

            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(_input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}

using System.Configuration;
using System.Diagnostics;

namespace HotelData
{
    public class clsErrorLog
    {

        static string sourceName = ConfigurationManager.AppSettings["ProjectName"];

        public static void LogMessageError(string messageError)
        {
            //log the error in event viewer

            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            // Log an information event
            EventLog.WriteEntry(sourceName, messageError, EventLogEntryType.Error);

        }
    }
}

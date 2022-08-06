using LogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Services
{
    public interface ILogService
    {
        Task<bool> LogToDatabase(IEnumerable<LogEntry> logEntries);
        Task<bool> LogToFlatFile(IEnumerable<LogEntry> logEntries);
        Task<bool> LogToKafka(IEnumerable<LogEntry> logEntries);
        Task<bool> LogToMQ(IEnumerable<LogEntry> logEntries);
        Task LogToFile(IEnumerable<LogEntry> logEntries);


    }
}

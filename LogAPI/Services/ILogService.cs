using LogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Services
{
    public interface ILogService
    {
        void LogToDatabase(LogEntry logEntry);
        Task<bool> SaveAsync();
        void LogToFlatFile(LogEntry logEntry);


    }
}

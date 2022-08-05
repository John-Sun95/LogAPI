using LogAPI.Data;
using LogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Services
{
    public class LogService : ILogService
    {
        private readonly LogDbContext _context;
        public LogService(LogDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void LogToDatabase(LogEntry logEntry)
        {
            if(logEntry == null)
            {
                throw new ArgumentNullException(nameof(logEntry));
            }
            else
            {
                _context.Add(logEntry);
            }
        }

        public void LogToFlatFile(LogEntry logEntry)
        {
            // ToDo
        }


        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}

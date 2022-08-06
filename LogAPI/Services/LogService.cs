using LogAPI.Data;
using LogAPI.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<bool> LogToDatabase(IEnumerable<LogEntry> logEntries)
        {
            if(logEntries == null)
            {
                throw new ArgumentNullException(nameof(logEntries));
            }
            else
            {
                foreach (var LogEntry in logEntries)
                {
                    _context.Add(LogEntry);
                }
              return await _context.SaveAsync();
            }
        }

        public async Task LogToFile(IEnumerable<LogEntry> logEntries)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\logs";
            string fileName = filePath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            FileStream fs;
            StreamWriter sw;
            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            }
            sw = new StreamWriter(fs);
            string log;
            foreach (var logEntry in logEntries)
            {
                log = JsonConvert.SerializeObject(logEntry);
                sw.WriteLine(log);
            }


            sw.Close();
            fs.Close();
        }

        public Task<bool> LogToFlatFile(IEnumerable<LogEntry> logEntries)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogToKafka(IEnumerable<LogEntry> logEntries)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogToMQ(IEnumerable<LogEntry> logEntries)
        {
            throw new NotImplementedException();
        }
    }
}

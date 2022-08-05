using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Entities
{
    public class LogEntry
    {
        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int TraceID { get; set; }
        public string Severity { get; set; }
        public string Timestamp { get; set; }
        public string Message { get; set; }
        public string ComponentName { get; set; }
        public int RequestId { get; set; }
    }
}

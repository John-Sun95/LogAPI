using System.ComponentModel.DataAnnotations;


namespace LogAPI.Entities
{
    public class LogEntry
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public int TraceID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Severity { get; set; }
        [Required]
        [MaxLength(30)]
        public string Timestamp { get; set; }
        [Required]
        [MaxLength(50)]
        public string Message { get; set; }
        [Required]
        [MaxLength(30)]
        public string ComponentName { get; set; }
        [Required]
        public int RequestId { get; set; }
    }
}

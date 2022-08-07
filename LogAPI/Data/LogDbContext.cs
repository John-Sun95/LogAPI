using LogAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LogAPI.Data
{
    public class LogDbContext: DbContext
    {
        public LogDbContext(DbContextOptions<LogDbContext> options): base(options)
        {
           
        }

        public DbSet<LogEntry> LogEntry { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<LogEntry>().Property(x => x.ApplicationID).IsRequired();
            modelBuilder.Entity<LogEntry>().Property(x => x.TraceID).IsRequired();
            modelBuilder.Entity<LogEntry>().Property(x => x.Severity).HasMaxLength(30).IsRequired(); ;
            modelBuilder.Entity<LogEntry>().Property(x => x.Timestamp).HasMaxLength(30).IsRequired(); ;
            modelBuilder.Entity<LogEntry>().Property(x => x.Message).HasMaxLength(50).IsRequired(); ;
            modelBuilder.Entity<LogEntry>().Property(x => x.ComponentName).HasMaxLength(30).IsRequired(); ;
            modelBuilder.Entity<LogEntry>().Property(x => x.RequestId).IsRequired(); ;

        }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() >= 0;
        }
    }
}

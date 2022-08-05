using LogAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            modelBuilder.Entity<LogEntry>().Property(x => x.ApplicationID).HasMaxLength(20);
            modelBuilder.Entity<LogEntry>().Property(x => x.TraceID).HasMaxLength(20);
            modelBuilder.Entity<LogEntry>().Property(x => x.Severity).HasMaxLength(20);
            modelBuilder.Entity<LogEntry>().Property(x => x.Timestamp).HasMaxLength(20);
            modelBuilder.Entity<LogEntry>().Property(x => x.Message).HasMaxLength(50);
            modelBuilder.Entity<LogEntry>().Property(x => x.ComponentName).HasMaxLength(10);
            modelBuilder.Entity<LogEntry>().Property(x => x.RequestId).HasMaxLength(20);

        }
    }
}

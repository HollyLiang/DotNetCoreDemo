using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreDemo
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        //public DbSet<WebLoggingModel> WebLogging { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebLoggingModel>().ToTable<WebLoggingModel>("syslogging");
        }
    }

    internal class WebLoggingModel
    {
        [Key]
        public int cix { get; set; }
    }
}

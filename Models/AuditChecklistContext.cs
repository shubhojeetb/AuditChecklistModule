using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuditChecklistModule.Models
{
    public class AuditChecklistContext : DbContext
    {
        public DbSet<Questions> Questions { get; set; }

        string connectionString = "Server=tcp:db-checklist.database.windows.net,1433;Initial Catalog=AuditCheckList;Persist Security Info=False;User ID=azureroot;Password=@12Shubho@12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}

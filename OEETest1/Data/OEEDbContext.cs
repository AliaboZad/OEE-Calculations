using Microsoft.EntityFrameworkCore;
using OEETest1.Models;

namespace OEETest1.Data
{
	public class OEEDbContext : DbContext
	{
        public OEEDbContext()
        {
            
        }
        public OEEDbContext(DbContextOptions options) : base (options) 
        {
            
        }

        public DbSet<Shifts> shifts { get; set; }
        public DbSet<MachineLogs> machines { get; set; }
        public DbSet<ProductionLogs> productions { get; set; }


    }
}

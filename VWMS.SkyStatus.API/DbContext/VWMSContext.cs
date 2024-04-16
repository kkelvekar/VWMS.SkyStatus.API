using Microsoft.EntityFrameworkCore;
using VWMS.SkyStatus.API.Entities;

namespace VWMS.SkyStatus.API
{
    public class VWMSContext : DbContext
    { 
        public DbSet<StatusMessage> StatusMessages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reference> References { get; set; }

        public VWMSContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StatusMessageDb;Trusted_Connection=True;");
        //}
    }
}

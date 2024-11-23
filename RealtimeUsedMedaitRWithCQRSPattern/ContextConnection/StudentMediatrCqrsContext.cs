using Microsoft.EntityFrameworkCore;

namespace RealtimeUsedMedaitRWithCQRSPattern.ContextConnection
{
    public class StudentMediatrCqrsContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public StudentMediatrCqrsContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
}

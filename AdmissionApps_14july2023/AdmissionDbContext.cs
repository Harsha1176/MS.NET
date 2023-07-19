using Microsoft.EntityFrameworkCore;

namespace AdmissionApps
{
    public class AdmissionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "server=localhost;database=admissiondb;uid=root;pwd=;";
            optionsBuilder.UseMySQL(con);
        }
        public DbSet<Users> Users { get; set; }
    }
}

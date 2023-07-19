using Microsoft.EntityFrameworkCore;

namespace AdmissionApp
{
    public class AdmissionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "server=localhost;database=admissiondb;uid=root;pwd=root;";
            optionsBuilder.UseMySQL(con);
        }
        public DbSet<Users> Users { get; set; }
    }
}

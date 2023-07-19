using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem
{
    public class EmpDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "server=localhost;database=employee_db;uid=root;pwd=root;";
            optionsBuilder.UseMySQL(con);
        }
        public DbSet<User> User { get; set; }
    }
}


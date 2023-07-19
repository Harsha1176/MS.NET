using Microsoft.EntityFrameworkCore;
using Project1.Models;
using System.Collections.Generic;

namespace Project1
{
    public class ProDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "server=localhost;database=testpro1;uid=root;pwd=root;";
            optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));
        }
        public DbSet<UserDBModel> Users { get; set; }//what table you are going to use

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCOREDEMO.DBModel
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
        [Column("Email")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Column("Password")]
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(15)]
        public string Mobile { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string   UserType { get; set; }


    }

    public class MyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

           
           optionsBuilder.UseMySQL("server=localhost;database=test_core;uid=root;pwd=root;");
        }
        public DbSet<Users> Users { get; set; }
    }

}

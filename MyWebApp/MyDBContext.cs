using Microsoft.EntityFrameworkCore;
using MyWebApp.Model;

namespace MyWebApp
{
    public class MyDBContext:DbContext
    {
        public DbSet<Student> Students{get; set;}
        public MyDBContext(DbContextOptions options):base(options){

        }
    }
}
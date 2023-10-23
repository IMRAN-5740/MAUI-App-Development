using CRUDOperationDemo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperationDemo.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}

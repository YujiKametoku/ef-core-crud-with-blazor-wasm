using Microsoft.EntityFrameworkCore;
using wasmapplication.Shared.Models;

namespace wasmapplication.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

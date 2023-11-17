using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebProjectTask.Core.Entities;

namespace WebProjectTask.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            :base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
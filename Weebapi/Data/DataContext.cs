using Microsoft.EntityFrameworkCore;
using Weebapi.Entities;

namespace Weebapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<AppUser> Users {get; set;}

    }
}
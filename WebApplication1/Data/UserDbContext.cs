using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<User> UserCredentials { get; set; }
    }
}

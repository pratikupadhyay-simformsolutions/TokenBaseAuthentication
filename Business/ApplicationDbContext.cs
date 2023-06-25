using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TokenBaseAuthentication.Models;

namespace TokenBaseAuthentication.Business
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

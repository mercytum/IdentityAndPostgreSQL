using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithIdentity.Models
{
    public class AppWithIdentityContext : DbContext
    {
        public AppWithIdentityContext(DbContextOptions<AppWithIdentityContext> options) 
            : base(options)
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}

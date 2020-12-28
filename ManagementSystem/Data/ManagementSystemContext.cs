using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Models;

namespace ManagementSystem.Data
{
    public class ManagementSystemContext : DbContext
    {
        public ManagementSystemContext (DbContextOptions<ManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<ManagementSystem.Models.Machine> Machine { get; set; }
    }
}

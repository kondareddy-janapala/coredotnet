using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProject.Models;

namespace MiniProjectTest.Data
{
    public class MiniProjectTestContext : DbContext
    {
        public MiniProjectTestContext (DbContextOptions<MiniProjectTestContext> options)
            : base(options)
        {
        }

        public DbSet<MiniProject.Models.Product> Product { get; set; }
    }
}

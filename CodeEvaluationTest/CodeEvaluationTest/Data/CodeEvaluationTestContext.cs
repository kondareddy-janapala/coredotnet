using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeEvaluationTest.Models;

namespace CodeEvaluationTest.Data
{
    public class CodeEvaluationTestContext : DbContext
    {
        public CodeEvaluationTestContext (DbContextOptions<CodeEvaluationTestContext> options)
            : base(options)
        {
        }

        public DbSet<CodeEvaluationTest.Models.Employee>? Employee { get; set; }
    }
}

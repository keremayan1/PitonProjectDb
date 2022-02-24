using Core.DataAccess.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class SqlContext : EfContextBase
    {
        public SqlContext(DbContextOptions<SqlContext> options, IConfiguration configuration) : base(options, configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = KEROSOFT\SQLEXPRESS; Database = PitonProjectDb; Trusted_Connection = true");
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanStatus> PlanStatus { get; set; }
    }
}

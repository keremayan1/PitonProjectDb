using Core.DataAccess.EntityFramework.Context;
using Core.Entities.EntityFramework.Concrete;
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
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlConnectionStrings"));
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanStatus> PlanStatus { get; set; }
       
        public DbSet<User> Users { get; set; }
    }
}

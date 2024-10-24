using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Infra.Data
{
    public class AppIdentityDbContextFactory : IDesignTimeDbContextFactory<AppIdentityDbContext>
    {
        public AppIdentityDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppIdentityDbContext>();
            
            //builder.UseSqlServer(ConnConfiguration.ConnectionString);
            builder.UseSqlite(ConnConfiguration.ConnectionString);

            return new AppIdentityDbContext(builder.Options);
        }
    }
}

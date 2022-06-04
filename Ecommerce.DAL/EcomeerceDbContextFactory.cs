using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.DAL
{
    public class EcomeerceDbContextFactory : IDesignTimeDbContextFactory<EcomerceDbContext>
    {
        private IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath("appsettings.json")
            .Build();

        public EcomerceDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EcomerceDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                options =>
                {
                    options.EnableRetryOnFailure();
                });
            return new EcomerceDbContext(optionsBuilder.Options);
        }
    }
}

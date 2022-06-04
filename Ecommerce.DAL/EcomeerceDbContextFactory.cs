using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.DAL
{
    public class EcomeerceDbContextFactory : IDesignTimeDbContextFactory<EcommerceDbContext>
    {
        private IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public EcommerceDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EcommerceDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                options =>
                {
                    options.EnableRetryOnFailure();
                });
            return new EcommerceDbContext(optionsBuilder.Options);
        }
    }
}

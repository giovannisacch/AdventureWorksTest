using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventureWorks.Repository.Context
{
    public class DbCreating : IDesignTimeDbContextFactory<AdventureContext>
    {
        private const string CONNECTIONSTRING = @"Data Source=DESKTOP-3EI2FUQ\SQLEXPRESS;Initial Catalog=ControlePedidos;Integrated Security=True";

        public AdventureContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().Build();

            var builder = new DbContextOptionsBuilder<AdventureContext>();
            builder.UseSqlServer(configuration.GetConnectionString("AdventureWorks"));

            return new AdventureContext(builder.Options);
        }
    }
}

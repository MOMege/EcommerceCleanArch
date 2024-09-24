﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecommerce.infrastructure.Presistance
{
    public class DBContextApplicationFactory : IDesignTimeDbContextFactory<DBContextApplication>
    {
        public DBContextApplication CreateDbContext(string[] args)
        { // Build configuration from appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get the connection string from configuration
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Create DbContextOptionsBuilder with the connection string
            var optionsBuilder = new DbContextOptionsBuilder<DBContextApplication>();
            optionsBuilder.UseSqlServer(connectionString);  // Adjust for your database provider

            // Return a new instance of DBContextApplication
            return new DBContextApplication(optionsBuilder.Options);
        }
    }
}

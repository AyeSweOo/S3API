using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gigz_API.Models;
using Microsoft.Extensions.Configuration;
using S3API.Models;
//using Gigz.Entities;

namespace Gigz_API.Models

{
    public class APIDbContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public APIDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<PayloadData> PayloadData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);




        }

    }
}

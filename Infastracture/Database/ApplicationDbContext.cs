using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Database
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<CustomerModels> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           string connectionString = "Server=(local); Database=ApiTest; Trusted_Connection=true;TrustServerCertificate=True;";

           optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

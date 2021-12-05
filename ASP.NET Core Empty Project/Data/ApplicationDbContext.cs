using ASP.NET_Core_Empty_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    public DbSet<PersonDb> People { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19890209-1234", Name = "Albin de Val", PhoneNr = "0721222324" });
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19700707-4321", Name = "Håkan Svensson", PhoneNr = "031555666777" });
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19801010-4125", Name = "Anders Andersson", PhoneNr = "1234567" });
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "20000909-0909", Name = "Max Verstappen", PhoneNr = "528582685" });
		}
	}
}

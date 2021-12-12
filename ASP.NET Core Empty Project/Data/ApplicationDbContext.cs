using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

		public DbSet<PersonDb> People { get; set; }
		public DbSet<CityDb> Cities { get; set; }
		public DbSet<CountryDb> Countries { get; set; }
		public DbSet<LanguageDb> Languages { get; set; }
		public DbSet<PersonLanguage> PersonLanguage { get; set; }
		public DbSet<ApplicationUser> Users { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<CityDb>()
				.HasOne(city => city.Country)
				.WithMany(country => country.Cities)
				.HasForeignKey(city => city.CountryId);

			modelBuilder.Entity<PersonDb>()
				 .HasOne(pe => pe.City)
				 .WithMany(ci => ci.Persons)
				 .HasForeignKey(pe => pe.CityId);


			modelBuilder.Entity<PersonLanguage>().HasKey(pl => new { pl.PersonId, pl.LanguageId });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Person)
                .WithMany(p => p.PersonLanguage)
                .HasForeignKey(pl => pl.PersonId);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pl => pl.Language)
                .WithMany(l => l.PersonLanguage)
                .HasForeignKey(pl => pl.LanguageId);


			modelBuilder.Entity<CountryDb>().HasData(new CountryDb { Id = 46, Name = "Sweden",});
			modelBuilder.Entity<CountryDb>().HasData(new CountryDb { Id = 47, Name = "Norway", });
			modelBuilder.Entity<CountryDb>().HasData(new CountryDb { Id = 358, Name = "Finland", });

			
			modelBuilder.Entity<CityDb>().HasData(new CityDb { Id = 1, Name = "Göteborg", CountryId = 46 });
			modelBuilder.Entity<CityDb>().HasData(new CityDb { Id = 2, Name = "Stockholm", CountryId = 46 });
			modelBuilder.Entity<CityDb>().HasData(new CityDb { Id = 3, Name = "Malmö", CountryId = 46 });
			modelBuilder.Entity<CityDb>().HasData(new CityDb { Id = 4, Name = "Oslo", CountryId = 47 });
			modelBuilder.Entity<CityDb>().HasData(new CityDb { Id = 5, Name = "Helsinki", CountryId = 358 }); 

			
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19890209-1234", Name = "Albin de Val", PhoneNr = "0721222324", CityId = 1});
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19700707-4321", Name = "Håkan Svensson", PhoneNr = "031555666777",CityId = 2 });
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "19801010-4125", Name = "Anders Andersson", PhoneNr = "01234567", CityId = 3 });
			modelBuilder.Entity<PersonDb>().HasData(new PersonDb { SSN = "20000909-0909", Name = "Max Verstappen", PhoneNr = "528582685", CityId = 4 });


			modelBuilder.Entity<LanguageDb>().HasData(new LanguageDb { Name = "Swedish", Id = 1 });
			modelBuilder.Entity<LanguageDb>().HasData(new LanguageDb { Name = "German", Id = 2 });
			modelBuilder.Entity<LanguageDb>().HasData(new LanguageDb { Name = "English", Id = 3 });

			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 1, PersonId = "19890209-1234" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 2, PersonId = "19890209-1234" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 3, PersonId = "19890209-1234" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 1, PersonId = "19700707-4321" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 2, PersonId = "19700707-4321" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 1, PersonId = "19801010-4125" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 3, PersonId = "19801010-4125" });
			modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage { LanguageId = 1, PersonId = "20000909-0909" });
		}
	}
}

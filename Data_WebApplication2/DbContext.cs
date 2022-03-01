using Data_WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_WebApplication2
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var country = new Country
            {
                Id = 1,
                Name = "Sweden"
            };

            modelBuilder.Entity<Country>().HasData(country);

            var city = new City
            {
                Id = 1,
                Name = "StockHolm",
                CountryId = country.Id
            };

            var city2 = new City
            {
                Id = 2,
                Name = "Gotenburg",
                CountryId = country.Id
            };

            var city3 = new City
            {
                Id = 3,
                Name = "Uppsala",
                CountryId = country.Id
            };

            modelBuilder.Entity<City>().HasData(city);
            modelBuilder.Entity<City>().HasData(city2);
            modelBuilder.Entity<City>().HasData(city3);

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    Name = "William",
                    PhoneNumber = "12345678",
                    CityId = city.Id
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

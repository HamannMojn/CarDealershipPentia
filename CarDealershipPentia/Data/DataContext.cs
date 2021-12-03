using CarDealershipApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace CarDealershipApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPurchase> CarPurchases {get; set;}
    }

    public class DbHelper
    {
        public static void SeedData(DataContext _context)
        {
            string[] names = { "Søren", "Lise", "Anna", "Bente" };
            string[] SurNames = { "Hansen", "Nielsen", "Svendsen", "Sørensen" };

            for(int i = 0; i<3; i++)
            {
                new Customer
                {
                    Name = names[i],
                    Surname = SurNames[i],
                    Address = new Address
                    {
                        Country = "Denmark",
                        HouseNumber = "12",
                        Street = "Koralvej",
                        Town = "Aarhus",
                        ZipCode = "8000"
                    },
                    Age = 50,
                    Created = System.DateTime.Now,
                    Purchases = [new CarPurchase
                    {
                        Car = List new Car
                        {
                            Color ="black"
                        })
                    }]
                    
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.IEntityFramework
{
    public class CarSQLContext : DbContext
        // Önce entitiyframeworkcore.sql serverı kurmamaız lazım bunun için => DataAccess'e sağ
                                      // tıklayın => Manage NuGet package => Browse kısmına entitiyframeworkcore.sql yazın =>
    {                               // 3.1.11 sürümünü yükleyin 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database = CarSQL;Trusted_Connection = true");// Hangi veritabanı ile ilişkili olduğunu belirttiğimiz yer.

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }


    }
}

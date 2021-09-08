using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class YugiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//hangi veri tabanı tanımlandığı yer.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocalDB;Database=Yugi;Trusted_Connection=True");
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardType { get; set; }
        public DbSet<Leaflet> Leaflet { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

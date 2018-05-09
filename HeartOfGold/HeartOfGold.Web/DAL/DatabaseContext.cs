using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeartOfGold.Web.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HeartOfGold.Web.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("HOGDatabase")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
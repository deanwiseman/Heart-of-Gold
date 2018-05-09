using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HeartOfGold.Web.Models;

namespace HeartOfGold.Web.DAL
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var items = new List<Item>
            {
                new Item{Name="Shoes", Description="Size 8 pair of white shoes", QuantityOnHand=2, Active=true, Category=CategoryName.Clothing},
                new Item{Name="Jacket", Description="Medium size black jacket", QuantityOnHand=1, Active=true, Category=CategoryName.Clothing},
                new Item{Name="C# 4.0 Development Book", Description="Programming textbook on C#", QuantityOnHand=2, Active=true, Category=CategoryName.Textbook},
            };

            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public enum CategoryName
    {
        Clothing,
        Toiletries,
        Monetary,
        Textbook,
    }

    public class Category
    {
        public int ID { get; set; }
        public CategoryName CategoryName { get; set; }
        public string Description { get; set; }
        

        public virtual ICollection<Item> Items { get; set; }
    }
}
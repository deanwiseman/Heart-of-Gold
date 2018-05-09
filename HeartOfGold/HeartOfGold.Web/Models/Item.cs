using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public class Item
    {
        public int ID { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryName Category { get; set; }
        public int QuantityOnHand { get; set; }
        public bool Active { get; set; }
    }
}
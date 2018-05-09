using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public class DonationItems
    {
        public int ID { get; set; }
        
        public int DonorID { get; set; }
        public Donor Donor { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
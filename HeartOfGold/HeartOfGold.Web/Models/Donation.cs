using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public class Donation
    {
        public int DonationID { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<DonationItems> DonationItems { get; set; }

    }
}
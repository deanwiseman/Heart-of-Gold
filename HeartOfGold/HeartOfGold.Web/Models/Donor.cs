using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public enum DonorType
    {
        Person,
        Company
    }
    public class Donor
    {
        public int DonorID { get; set; }
        public DonorType Type { get; set; }
        public string Email { get; set; }
    }
}
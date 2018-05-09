using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public class Residence
    {
        public int ResidenceID { get; set; }

        public virtual ICollection<Student> Students { get; set; } 
    }
}
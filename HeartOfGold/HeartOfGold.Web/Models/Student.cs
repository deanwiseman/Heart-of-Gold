using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
        public int? PhoneNumber { get; set; }
        public int? ResidenceID { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

         

    }
}
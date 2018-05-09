using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeartOfGold.Web.Models
{
    public enum Status
    {
        Open,
        Closed,
        Pending,
        Rejected,
    }

    public class Request
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public Student Student { get; set; }


        public virtual ICollection<RequestItem> Items { get; set; }

    }
}
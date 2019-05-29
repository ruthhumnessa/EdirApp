using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public Edir Edir{ get; set; }
        public int EdirId { get; set; }

        public string Name { get; set; }
        public decimal Payment { get; set; }

        public DateTime? Date { get; set; }
    }
}
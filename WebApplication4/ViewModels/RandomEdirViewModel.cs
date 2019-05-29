using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class RandomEdirViewModel
    {
        public  Edir Edir { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class NewCustomerViewModel
    {

        public IEnumerable<Edir> Edirs { get; set; }
        public IEnumerable<Customer> CustomerIE { get; set; }

        public Customer Customers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {


            var customers = _context.Customers.Include(c => c.Edir).Where(c=>c.EdirId==c.Edir.Id).ToList();


            return View(customers);
        }

        public ViewResult New()
        {
            var edir = _context.Edirs.Include(m=>m.Id).ToList();
            var viewModel = new NewCustomerViewModel
            {
                Edirs = edir
            };
            return View("New", viewModel);
        }


        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            var edir = _context.Edirs.Include(m => m.Id).ToList();

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c=>c.Id==c.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Payment = customer.Payment;
                customerInDb.Date = customer.Date;
                
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");

        }

    }
}
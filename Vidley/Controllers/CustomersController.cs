using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context= new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
           
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);

        }

        public ActionResult New()
        {
            var membershiptypes = _context.MemberShipTypes.ToList();
            var viewmodel = new CustomerFormViewModel()
            {
                Customer =  new Customer(),
                MemberShipTypes = membershiptypes
            };
            return View("CustomerForm",viewmodel);
        }

        [HttpPost]
        public ActionResult Save(CustomerFormViewModel customerForm)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer =  customerForm.Customer,
                    MemberShipTypes =  _context.MemberShipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if (customerForm.Customer.Id == 0)
            {
                _context.Customers.Add(customerForm.Customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customerForm.Customer.Id);
                customerInDb.Name = customerForm.Customer.Name;
                customerInDb.BirthDate = customerForm.Customer.BirthDate;
                customerInDb.MemberShipTypeId = customerForm.Customer.MemberShipTypeId;
                customerInDb.IsSubscribedToNewsletter = customerForm.Customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
              Customer = customer,
              MemberShipTypes =  _context.MemberShipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}
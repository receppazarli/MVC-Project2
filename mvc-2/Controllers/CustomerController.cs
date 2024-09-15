using mvc_2.Data;
using mvc_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_2.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult Index()
        {
            return View(CustomerData.Customers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customerData)
        {
            CustomerData.Customers.Add(customerData);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var customer = CustomerData.Customers.
                Where(x => x.Id == id).FirstOrDefault();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(Customer newCustomer)
        {
            Customer editCustomer = CustomerData.Customers.
                Where(x => x.Id == newCustomer.Id).FirstOrDefault();

            editCustomer.FirstName = newCustomer.FirstName;
            editCustomer.LastName = newCustomer.LastName;
            editCustomer.Address = newCustomer.Address;
            editCustomer.City = newCustomer.City;
            editCustomer.County = newCustomer.County;
            editCustomer.NationalityId = newCustomer.NationalityId;
            editCustomer.Phone = newCustomer.Phone;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Customer newcustomer)
        {
            var customer = CustomerData.Customers.
                Where(x => x.Id == newcustomer.Id).FirstOrDefault();
            CustomerData.Customers.Remove(customer);
            return View(customer);
        }
    }
}
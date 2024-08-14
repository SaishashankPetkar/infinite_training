using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CC1.Models;

namespace CC1.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Que1
        public ActionResult Index()
        {
            List<string> germancust = (from g in db.Customers
                                       where g.City == "Germany"
                                       select g.ContactName).ToList();
            if (germancust.Any())
            {
                return View(germancust);
            }
            else
            {
                var noCustomerMessage = new List<string> { "No customers found" };
                return View(noCustomerMessage);
            }
        }

        public ActionResult CustomerByOrderId()
        {
            var customerDetails = (from o in db.Orders
                                   join c in db.Customers on o.CustomerID equals c.CustomerID
                                   where o.OrderID == 10248
                                   select c).ToList();
            return View(customerDetails);
        }
    }
}
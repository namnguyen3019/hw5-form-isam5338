using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hw4_form.Models;

namespace hw4_form.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FormSubmit()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult GetFormDetails(string FirstName, string LastName, string StreetAddress, string ZipCode, string City, string State, Boolean FreeSample)
        {
            CustomerForm newCustomer = new CustomerForm();
            newCustomer.FirstName = FirstName;
            newCustomer.LastName = LastName;
            newCustomer.StreetAddress = StreetAddress;
            newCustomer.ZipCode = ZipCode;
            newCustomer.City = City;
            newCustomer.State = State;
            newCustomer.FreeSample = FreeSample;
            return View(newCustomer);
        }
       
    }
}

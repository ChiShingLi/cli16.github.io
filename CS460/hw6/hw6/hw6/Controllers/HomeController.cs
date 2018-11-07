using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw6.Models;
using hw6.Models.ViewModels; //import model to use database references

namespace hw6.Controllers
{
    public class HomeController : Controller
    {
        //init database, use default table for the search function
        public EFWideWorldImportersContext database = new EFWideWorldImportersContext();

        public ActionResult Index()
        {
            return View();
        }


        //default get page
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        //POST method page when user submit something, use the passed in input (clientName)
        [HttpPost]
        public ActionResult Search(string clientName)
        {
            //check if the list is empty, display error if it is
            var clientResultCheck = database.People.Where(person => person.FullName.Contains(clientName)).ToList();
            if (clientResultCheck.Count() == 0)
            {
                ViewBag.resultText = "I'm sorry, your search returned no results.";
            }

            //check & see did user have inputted seomthing or not, by looking at the length of the input variable
            if (clientName.Length > 0 && clientResultCheck.Count() != 0)
            {
                //found atleast one record, client is not empty 
                ViewBag.clientNameIsEmpty = false;

                //set the result text
                ViewBag.resultText = "Names matching your search: " + "\"" + clientName + "\"";

                //query to get check if a record contains clientName in the People table & convert it into a list
                var clientResult = database.People.Where(person => person.FullName.Contains(clientName)).ToList();


                //pass back the result Model into the View
                //use var, since if don't know/easier what type is returning back    
                return View(clientResult);
            }
            return View();
        }


        //For Person details page, use custom PersonDashboard ViewModel to pass in multiple table objects instead of default one.
        public PersonDashboardVM vm = new PersonDashboardVM();

        //get the clientID, use int? since the variable maybe null
        public ActionResult Person(int? id)
        {
            //----- if not passing an parameter-----
            //parse out the clientID, then convert string to int
            //string path = Request.Url.AbsoluteUri;
            //string clientIdString = path.Split('/').Last();
            //int clientId = Int32.Parse(clientIdString);

            //default check if the client is also a customer (company check)
            ViewBag.companyExists = false;


            //check and see if the client exist in the database
            var clientCheckExist = database.People.Find(id);


            if (clientCheckExist == null)
            {
                ViewBag.client = "Error: Client does not exist in the database.";
            }

            //send the People object into vm.Person
            vm.Person = database.People.Find(id);

            //check if that person is also an customer of the company.
            if (vm.Person.Customers2.Count() > 0) //if their count is great than 0
            {
                //show the tables in View
                ViewBag.companyExists = true;

                //show the company info table, use First() instead of FirstOrDefault, because it have atleast one element
                //get the customer ID from Customers2 
                int customerID = vm.Person.Customers2.First().CustomerID;
                vm.Customer = database.Customers.Find(customerID);

                //get the purchase history info
                //count up the number of orders
                vm.TotalOrders = vm.Customer.Orders.Count;

                //sum up all the extendedprice in invoices -> InvoiceLines as decimal
                vm.GrossSales = vm.Customer.Orders.SelectMany(item => item.Invoices).SelectMany(item => item.InvoiceLines).Sum(item => item.ExtendedPrice);

                vm.GrowthProfit = vm.Customer.Orders.SelectMany(item => item.Invoices).SelectMany(item => item.InvoiceLines).Sum(item => item.LineProfit);

                //same as above except, getting 10 items from the lineProfit and convert it to list
                vm.InvoiceLine = vm.Customer.Orders.SelectMany(item => item.Invoices).SelectMany(item => item.InvoiceLines).OrderByDescending(item => item.LineProfit).Take(10).ToList();
            }

            //else it exists, send the client info object into the view.
            return View(vm);
        }
    }
}
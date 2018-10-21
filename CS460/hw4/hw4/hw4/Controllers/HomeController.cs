using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace hw4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Converter()
        {
            string miles = "NULL";
            miles = Request.QueryString["miles"];
            double milesValue = Convert.ToDouble(miles); //convert string into double
            double result = -1;
            string radioOption = "NULL";
            radioOption = Request.QueryString["units"];

            //convertion formula
            const double MILLIMETERS = 1609000;
            const double CENTIMETERS = 160934;
            const double METERS = 1609.34;
            const double KILOMETERS = 1.60934;

            if (miles != null && radioOption != null)
            {
                //check for selected option
                if (radioOption == "millimeters")
                {
                    milesValue *= MILLIMETERS;
                }

                if (radioOption == "centimeters")
                {
                    milesValue *= CENTIMETERS;
                }

                if (radioOption == "meters")
                {
                    milesValue *= METERS;
                }

                if (radioOption == "kilometers")
                {
                    milesValue *= KILOMETERS;
                }

                //result
                result = milesValue;
                ViewBag.result = miles + " miles is equal to " + result + " " + radioOption;

            }

            return View();
        }

    }
}
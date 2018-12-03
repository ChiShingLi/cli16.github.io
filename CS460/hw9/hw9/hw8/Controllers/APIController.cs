using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.Models;

namespace hw8.Controllers
{
    public class APIController : Controller
    {
        //declare db connection
        private EFdbContext db = new EFdbContext();

        // GET: API
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AllBids(int? id)
        {
            ////getting the item name from Items from the database by specific id
            ////getting the Bids from the database by specific id

            db.Configuration.ProxyCreationEnabled = false; //turn it off, to avoid infinite loop error message
            var result = db.Bids.Where(x => x.Item == id) //use Equals for other stuff, == for id
                .OrderByDescending(y => y.Price)//order by price, highest bid first
                .ToList(); //return as a list

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
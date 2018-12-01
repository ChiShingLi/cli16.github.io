using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.DAL;
using hw8.Models.VM;

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
            AuctionDashboard BidResult = new AuctionDashboard();

            //getting the item name from Items from the database by specific id

            //BidResult.Items.
            //getting the Bids from the database by specific id
            var result = BidResult.Bids = db.Bids            
                .Where(x => x.Item == id)      //use Equals for other stuff, == for id
                .OrderByDescending(y => y.Price) //order by price, highest bid first
                .ToList(); //return as a list
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.Models;

namespace hw8.Controllers
{
    public class HomeController : Controller
    {
        //getting data from the item database
        EFdbContext db = new EFdbContext();

        public ActionResult Index()
        {

            //get the 10 recent bids 
            var recentBids = db.Bids.OrderByDescending(m => m.Timestamp) //sort the bids by timestamp
                .Take(10) //get the first 10
                .ToList(); //return as a list

            //pass in the bid model
            return View(recentBids);
        }

        public ActionResult confirmation()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Bid()
        {
            //ViewBag. Item is a SelectList 
            //viewBag for droplist
            //getting data from database
            //aka: ViewBag.Item = new SelectList(<database.table>, <"property value">, <"Property name for user to see">)
            ViewBag.Item = new SelectList(db.Items, "ID", "Name");
            ViewBag.Buyer = new SelectList(db.Buyers, "BuyerName", "BuyerName");

            return View();
        }

        [HttpPost]
        public ActionResult Bid([Bind(Include = "ID,Item,Buyer,Price,Timestamp")] Bid BidObject)
        {
            
            EFdbContext db = new EFdbContext();
            db.Bids.Add(BidObject);
            db.SaveChanges();

            //return a different page or error
            return View("confirmation");
        }
    }
}
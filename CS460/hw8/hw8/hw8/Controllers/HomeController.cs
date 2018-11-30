using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hw8.DAL;
using System.Data.Entity;
using hw8.Models;
using hw8.Models.VM;

namespace hw8.Controllers
{
    public class HomeController : Controller
    {
        private EFdbContext db = new EFdbContext();

        
        public ActionResult Index()
        {
            //get the 10 recent bids 
            var recentBids = db.Bids.OrderByDescending(m => m.Timestamp) //sort the bids by timestamp
                .Take(10) //get the first 10
                .ToList(); //return as a list

            //pass in the bid model
            return View(recentBids);
        }

        public ActionResult Bid()
        {
            //viewBag for droplist
            //getting data from database
            //aka: ViewBag.Item = new SelectList(<database.table>, <"property name">, <"Property name">)
            ViewBag.Item = new SelectList(db.Items, "ID", "ID");
            ViewBag.Buyer = new SelectList(db.Buyers, "BuyerName", "BuyerName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //get and store the response back into BidObject
        //bind allow which model property to access database
        public ActionResult Bid([Bind(Include = "ID,Item,Buyer,Price,Timestamp")] Bid BidObject)
        {
            db.Bids.Add(BidObject);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
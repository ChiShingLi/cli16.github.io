using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw8.Models.VM
{
    public class AuctionDashboard
    {
        public Item Item { get; set; }
        public IEnumerable<Bid> Bids { get; set; }
    }
}
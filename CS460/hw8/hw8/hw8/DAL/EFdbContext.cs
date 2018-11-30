using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hw8.Models;
using System.Data.Entity; //for db connections



namespace hw8.DAL
{
    public class EFdbContext : DbContext
    {
        public EFdbContext() : base("name=AuctionDatabase") { }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

    }
}
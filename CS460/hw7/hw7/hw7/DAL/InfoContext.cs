using System;
using System.Collections.Generic;
using System.Data.Entity; //include this for DbContext
using System.Linq;
using System.Web;
using hw7.Models;


namespace hw7.DAL
{
    public class InfoContext : DbContext
    {
        public InfoContext() : base("name=Infos")  {}

        public virtual DbSet<Info> Infos { get; set; }
    }
}
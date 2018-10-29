using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using hw5.Models;


namespace hw5.DAL
{
    public class DataContext : DbContext
    {
        //database name = Data
        public DataContext() : base("name=Data")
        {
        }

        public virtual DbSet<Renter> Renters { get; set; }
    }
}
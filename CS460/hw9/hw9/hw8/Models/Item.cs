using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace hw8.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(30)]
        public string Seller { get; set; }

        //public virtual ICollection<Bid> Bids { get; set; }

    }
}
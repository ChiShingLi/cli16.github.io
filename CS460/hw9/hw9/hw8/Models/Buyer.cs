using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace hw8.Models
{
    public class Buyer
    {
        
        public int ID { get; set; }

        [StringLength(30)]
        public string BuyerName { get; set; }


    }
}
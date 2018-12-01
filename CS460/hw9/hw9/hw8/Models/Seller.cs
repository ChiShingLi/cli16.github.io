﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace hw8.Models
{
    public class Seller
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string SellerName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace hw6.Models.ViewModels
{
    public class PersonDashboardVM
    {
        //we need the person table object from the database
        public Person Person { get; set; }

        //we need the Customer table object from the database
        public Customer Customer { get; set; }

        public List<InvoiceLine> InvoiceLine { get; set; }

        public int TotalOrders { get; set; }

        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal GrossSales { get; set; }

        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal GrowthProfit { get; set; }
    }
}
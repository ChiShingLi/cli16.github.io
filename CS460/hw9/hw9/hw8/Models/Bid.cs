using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace hw8.Models
{
    public class Bid
    {

        [Key]
        public int ID { get; set; } 

        public int Item { get; set; }

        public string Buyer { get; set; }

        //display money format
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Price { get; set; }

        public DateTime currentDate = DateTime.Now;

        public DateTime Timestamp
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        //allow access to item, to get the Item Name from item database to use in the index list.
        //only need 'get' to read the data.
            

        public virtual Item Items { get; }
    }

}
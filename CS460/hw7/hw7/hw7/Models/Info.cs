using System;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace hw7.Models
{
    public class Info 
    {
        [Key]
        public int ID { get; set; }

        public DateTime currentDate = DateTime.Now;

        public DateTime RequestDate {
            get { return currentDate; }
            set { currentDate = value; }
        }

        public string WordSearched { get; set; }

        public string IpAddress { get; set; }

        public string BrowserAgent { get; set; }

    }
}
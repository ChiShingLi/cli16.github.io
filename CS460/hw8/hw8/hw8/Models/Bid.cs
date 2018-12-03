namespace hw8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        
        public int ID { get; set; }

        public int Item { get; set; }

        [Required]
        [StringLength(30)]
        public string Buyer { get; set; }

        //display money format
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Price { get; set; }

        public DateTime currentTime = DateTime.Now;

        public DateTime Timestamp {
            get { return currentTime; }
            set { currentTime = value; }
           
        }

        public virtual Item Item1 { get; set; }

        public virtual Buyer Buyer1 { get; set; }
    }
}

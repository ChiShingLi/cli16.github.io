using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace hw5.Models
{
    public class Renter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { set; get; }

        [Required]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter an valid phone number.")]
        public string Phone { set; get; }

        [Required]
        public string ApartmentName { set; get; }

        [Required]
        public int UnitNumber { set; get; }

        [Required]
        public string CommentBox { set; get; }

        //get timestamp
        public DateTime GetCurrentTime = DateTime.Now;

        public DateTime CurrentTime
        {
            set { GetCurrentTime = value; }
            get { return GetCurrentTime; }

        }

        //[Required(ErrorMessage = "You must agree to the agreement, in order for us to provide the service to you.")]
        public bool AgreementChecked { set; get; }



    }
}
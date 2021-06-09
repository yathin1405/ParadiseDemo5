using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using ParadiseDemo5.Models;

namespace ParadiseDemo5.Models
{
    public class UserTour 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public virtual Tour TourType { get; set; }
        public virtual Tour TourID { get; set; }
        public decimal CostOfBooking { get; set; }
        public decimal DepositForBooking { get; set; }
        public string BookingStatus { get; set; }
        public bool IsActive { get; set; }
        public string PaymentMethod { get; set; }

    }


}

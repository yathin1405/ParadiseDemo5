using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ParadiseDemo5.Models
{
    public class Bookingcs
    {
        internal object capacity;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BookingID { get; set; }
        //public Guid Tour_ID { get; set; }
        //[ForeignKey("Tour_ID")]
        public virtual Tour Tours { get; set; }
        public int Cust_ID { get; set; }
             
        public int NumAdults { get; set; }
        public int NumKids { get; set; }
        public virtual Tour deposit{ get;set;}
        public virtual  Tour TotalCost { get; set; }
        public virtual Tour Discount { get; set; }


    }
}

//booking id, cust id, tour id, cost, deposit

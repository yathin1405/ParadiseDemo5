using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseDemo5.Models
{
    public class Cruise
    {
        public enum From
        {
            JHB,
            Durban,
            Capetown,

        }
        public enum To
        {
            JHB,
            Durban,
            Capetown,

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Cruise ID")]
        public int CruiseID { get; set; }

        [Display(Name = "Cruise Name")]
        public string Cruise_Name { get; set; }

        [Display(Name = "Cruise Duration")]
        public string Cruise_Duration { get; set; }

        [Display(Name = "Number of guests")]
        public string Num_Guests { get; set; }
        [Display(Name = "Guest Type")]
        public string Guest_Type { get; set; }

        //[Display(Name = "From")]
        //public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }


        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }



        [Display(Name = "Cruise Type")]
        [Required(ErrorMessage = " required")]
        [MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public string Cruise_Type { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        //[Display(Name = "Deposit")]
        //[Required(ErrorMessage = "Deposit Required")]
        public double Deposit { get; set; }

        public double deposit()
        {

            double deposit = 0;
            if (Price <= 15000)
            {
                deposit = Price * 0.15;
            }
            else
                if (Price > 15000 && Price <= 30000)
            {
                deposit = Price * 0.20;
            }
            else
                if (Price > 30000 && Price <= 50000)
            {
                deposit = Price * 0.25;
            }
            else
                if (Price > 50000 && Price <= 80000)
            {
                deposit = Price * 0.30;
            }
            else
                if (Price > 80000)
            {
                deposit = Price * 0.40;
            }
            return deposit;
        }
    }
}
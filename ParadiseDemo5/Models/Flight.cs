using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseDemo5.Models
{
    public class Flight
    {

        public Airline Airways { get; set; }
        public enum Airline
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        public From FROM { get; set; }
        public enum From
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public To TO { get; set; }
        public enum To
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public Class SeatType { get; set; }
        public enum Class
        {
            Economy,
            Business,
            First,

        }
        public Passenger PassengerType { get; set; }
        public enum Passenger
        {
            Adult,
            child,
            infant,
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Plane ID")]
        public int PlaneID { get; set; }

        //[Display(Name = "Plane Name")]
        //public string Plane_Name { get; set; }

        [Display(Name = "Flight Duration")]
        public string Flight_Duration { get; set; }

        [Display(Name = "Flight Delay")]
        public bool FDelay { get; set; }
        [Display(Name = "Estimated Flight Delay")]
        public string Flight_Delay { get; set; }

        public int[] NumberOfSeats;
        public int[] NumberOfSeatsLeft;
        public int[] ReservedSeats;
        [Display(Name = "Plane Capacity")]
        public string Plane_Capacity { get; set; }
        [Display(Name = "Seating Type")]
        public string Seat_Type { get; set; }

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

        [Display(Name = "Passenger Type")]
        [Required(ErrorMessage = " required")]
        public string Passenger_Type { get; set; }

        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        [Display(Name = "Number of tickets")]
        [Required(ErrorMessage = "Required")]
        public int NumOfTickets { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }
        public enum SeatAvail
        {
            Available,
            Unavailable,
        }
        public double Airline_Fee { get; set; }
        public double Ticket_Price { get; set; }
        public double passenger_Cost { get; set; }
        public double AirlineFee()
        {
            double x = 0;

            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.Mango && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.Mango && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.Mango && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.Mango && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.British_Airways && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.British_Airways && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.British_Airways && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.British_Airways && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }

            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.Kulula && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.Kulula && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.Kulula && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.Kulula && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.King_Shaka_International)
            {
                x = 500;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.Lanseria)
            {
                x = 550;

            }
            if (Airways == Airline.SAA && FROM == From.CapeTown_International && TO == To.OR_Tambo)
            {
                x = 600;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.CapeTown_International)
            {
                x = 650;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.Lanseria)
            {
                x = 700;

            }
            if (Airways == Airline.SAA && FROM == From.King_Shaka_International && TO == To.OR_Tambo)
            {
                x = 750;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.King_Shaka_International)
            {
                x = 800;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.CapeTown_International)
            {
                x = 850;

            }
            if (Airways == Airline.SAA && FROM == From.Lanseria && TO == To.OR_Tambo)
            {
                x = 900;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.King_Shaka_International)
            {
                x = 1000;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.CapeTown_International)
            {
                x = 1050;

            }
            if (Airways == Airline.SAA && FROM == From.OR_Tambo && TO == To.Lanseria)
            {
                x = 200;

            }
            return x;

        }

        public double TicketPrice()
        {
            double x = 0;


            if (SeatType == Class.Economy && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (SeatType == Class.Business && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (SeatType == Class.First && Return_Flight == true)
            {
                x = ((AirlineFee() + passengerCost()) + ((passengerCost() + AirlineFee()) * 66.66));
            }
            else if (SeatType == Class.Business)
            {
                x = AirlineFee() + passengerCost();
            }
            else if (SeatType == Class.Economy)
            {
                x = AirlineFee() + passengerCost();
            }
            else if (SeatType == Class.First)
            {
                x = AirlineFee() + passengerCost();
            }
            return x;
        }

        public double passengerCost()
        {
            double x = 0;

            if (PassengerType == Passenger.Adult)
            {
                x = 75;
            }
            if (PassengerType == Passenger.child)
            {
                x = 50;
            }
            if (PassengerType == Passenger.infant)
            {
                x = 10;
            }
            return x;
        }

        //for(i=Plane_Capacity;NumOfTickets<Plane_Capacity;i--){}

    }
}
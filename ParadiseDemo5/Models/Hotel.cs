using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseDemo5.Models
{
    public class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Hotel ID")]
        public int HotelID { get; set; }

        //[Display(Name = "Hotel Name")]
        //public string Hotel_Name { get; set; }

        //[Display(Name = "Cruise Duration")]
        //public string Cruise_Duration { get; set; }

        [Display(Name = "Name of guests")]
        public string Name_Guests { get; set; }
        [Display(Name = "Number of Adults")]
        public string Num_Adults { get; set; }
        [Display(Name = "Number of Children")]
        public string Num_Children { get; set; }

        //[Display(Name = "Email adddress")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[Display(Name = "Number of guests")]
        ////public string Num_Guests { get; set; }
        [Display(Name = "Guest Type")]
        public string Guest_Type { get; set; }



        //[Display(Name = "Check in ")]
        //[DataType(DataType.Date)]
        //public DateTime CheckIn{ get; set; }


        //[Display(Name = "Check out ")]
        //[DataType(DataType.Date)]
        //public DateTime CheckOut { get; set; }



        //[Display(Name = "Room Type")]
        //[Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        //public string Room_Type { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public double TPrice { get; set; }
        public float Price { get; set; }
        //work out days between 2 date pickers
        // booking()- (Price*NumGuests)+RoomType()+Breakfast()
        //RoomType- if single then x=500
        //enum for room type, guest type
        //Boolean for breakfast
        //Breakfast()
        //bool Meal
        //MealType()-veg,meat 
        [Display(Name = "Hotel Name")]
        public Hotel_Name Hotels { get; set; }
        public enum Hotel_Name
        {
            Belmond_Mount_Nelson_Hotel,//western cape
            The_Cellars_Hohenort,//western cape
            Delaire_Graff_Lodge,//western cape
            Four_Seasons_hotel_The_Westcliff,//Gauteng
            Saxon_hotel,//Gauteng
            Pearls_Of_Umhlanga,//KZN
            The_Oyster_box,//KZN
            Endless_Horizons_boutique,//KZN
            ParkWood_boutique_hotel,//Gauteng

        }

        [Display(Name = "Number of guests")]
        public Num_Guests NumOfGuests { get; set; }
        public enum Num_Guests
        {
            Single_Adult,//1 person
            Two_Adults,//2 people
            Three_Adults,//3 people
            Four_adults,//4 poeple
            Single_adult_and_Single_Child,//2 peolpe
            Single_Adult_and_Single_Infant,//2 people
            Single_Adult_and_two_Children,//3 people
            Single_Adult_and_Two_Infant,//3 people
            Two_Adults_and_One_Child,//3 poeple
            Two_Adults_and_One_Infant,//3 poeple
            Single_Adult_and_One_Child_and_one_Infant,//3 poeple
            Three_Adults_and_One_Child,//4 people
            Three_Adults_and_One_Infant,//4 poelpe
            Two_Adults_and_Two_Child,//4 people
            Two_Adults_and_Two_Infant,// 4 poeple
            Single_Adult_and_Three_Children,//4 poeple
            Single_Adult_and_Three_Infant,//4 poeple
            Two_Adults_and_One_Child_and_One_Infant,//4 people

        }






        [Display(Name = "Room Type")]
        [Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public Room_Type Rooms { get; set; }
        public enum Room_Type
        {
            Single_Person_NoView,
            Two_People_NoView,
            Three_People_NoView,
            Four_People_NoView,
            Single_Person_View,
            Two_People_View,
            Three_People_View,
            Four_People_View,

        }

        [Display(Name = " Breakfast?")]
        public bool Breakfast { get; set; }
        public double Breakfast_Price { get; set; }
        public string Meal_Type { get; set; }
        public double RoomType_Price { get; set; }

        public double BreakfastPrice()
        {
            double x = 0;
            if (Breakfast == true)
            {
                x = 150;
            }
            return x;
        }

        public Meal MealType { get; set; }
        public enum Meal
        {
            Meat,
            Veg,
            No,
        }


        public double MealPrice()
        {
            double x = 0;
            if (MealType == Meal.Meat)
            {
                x = 200;
            }
            if (MealType == Meal.Veg)
            {
                x = 140;
            }
            if (MealType == Meal.No)
            {
                x = 0;

            }
            return x;
        }



        public double RoomTypePrice()
        {
            double x = 0;
            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view

            /////////////////////////////////////////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Belmond_Mount_Nelson_Hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view

            //////////////////////////////////////////////////////////////////////////////////////


            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view

            /////////////////////////////////////////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Cellars_Hohenort && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
            //////////////////////////////////////////////////////////////////
            ///

            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              //////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Delaire_Graff_Lodge && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
              //////////////////////////////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              ////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Four_Seasons_hotel_The_Westcliff && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
              ////////////////////////

            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              /////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Saxon_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
            /////////////////
            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view

            ////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.ParkWood_boutique_hotel && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
              ////////////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view

            ///////////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.The_Oyster_box && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view
              ///////////////////////////
            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              /////////////////////////////////////////

            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Pearls_Of_Umhlanga && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view

            /////////////////////////////////

            if (Rooms == Room_Type.Single_Person_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2 no view

            if (Rooms == Room_Type.Two_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3  no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Three_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4 no view

            if (Rooms == Room_Type.Four_People_NoView && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4 no view
              /////////////////////
            ///
            if (Rooms == Room_Type.Single_Person_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult)
            {
                x = 300;
            }//price for 1 adult in a room for 1  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults)
            {
                x = 500;

            }// price for 2 adults in a room for2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_adult_and_Single_Child)
            {
                x = 450;

            }// price for 1 adult and 1 child  in a room for 2  view

            if (Rooms == Room_Type.Two_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Single_Infant)
            {
                x = 350;

            }// price for 1 adult and 1 baby in a room for 2 view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults)
            {
                x = 775;
            }// price for 3 adults in a room for 3   view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_two_Children)
            {
                x = 705;
            }// price for 1 adults and 2 children in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Two_Infant)
            {
                x = 690;
            }// price for 1 adults 2 babies in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Child)
            {
                x = 775;
            }// price for 2 adults and 1 child in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Infant)
            {
                x = 775;
            }// price for 2 adults and 1 baby in a room for 3  view

            if (Rooms == Room_Type.Three_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_One_Child_and_one_Infant)
            {
                x = 775;
            }// price for 1 adult, 1 child, 1 baby in a room for 3  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Four_adults)
            {
                x = 1000;
            } // price for  4 adults in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults_and_One_Child)
            {
                x = 1000;
            } // price for  3 adults 1 child in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Three_Adults_and_One_Infant)
            {
                x = 1000;
            } // price for  3 adults  1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_Two_Child)
            {
                x = 1000;
            } // price for  2 adults 2 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_Two_Infant)
            {
                x = 1000;
            } // price for  2 adults 2 babies in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Two_Adults_and_One_Child_and_One_Infant)
            {
                x = 1000;
            } // price for  2 adults,1 child, 1 baby in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Three_Children)
            {
                x = 1000;
            } // price for  1 adult 3 children in a room for 4  view

            if (Rooms == Room_Type.Four_People_View && Hotels == Hotel_Name.Endless_Horizons_boutique && NumOfGuests == Num_Guests.Single_Adult_and_Three_Infant)
            {
                x = 1000;
            } // price for  1 adults 3 babies in a room for 4  view

            return x;
        }

    }
}
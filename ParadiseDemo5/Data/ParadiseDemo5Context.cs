using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParadiseDemo5.Data
{
    public class ParadiseDemo5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ParadiseDemo5Context() : base("name=ParadiseDemo5Context")
        {
        }

        public System.Data.Entity.DbSet<ParadiseDemo5.Models.Tour> Tours { get; set; }

        public System.Data.Entity.DbSet<ParadiseDemo5.Models.Hotel> Hotels { get; set; }

        public System.Data.Entity.DbSet<ParadiseDemo5.Models.UserTour> UserTours { get; set; }

        public System.Data.Entity.DbSet<ParadiseDemo5.Models.Bookingcs> Bookingcs { get; set; }

        public System.Data.Entity.DbSet<ParadiseDemo5.Models.Customer> Customers { get; set; }
    }
}

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ParadiseDemo5.Data;
using ParadiseDemo5.Models;
using VisioForge.Shared.MediaFoundation.OPM;

namespace ParadiseDemo5.Controllers
{
    public class BookingcsController : Controller
    {
        private ParadiseDemo5Context db = new ParadiseDemo5Context();
        private readonly object loggedinUser;

        // GET: Bookingcs
        public ActionResult Index()
        {
            //{  IList<Vehicle> VeichL = new List<Vehicle>();
            //if (User.Identity.User() == "adminash@gmail.com")
            //{
            //    return View(db.VehiclesTB.ToList());
            //}
            //else
            {
                //var loggedinUser = User.Identity.GetUserName();

                var book = (from x in db.Bookingcs
                            join e in db.Tours
                            //on  /*e.TourID*/
                             on x.capacity equals e.TourID
                            where e.Email.Equals(loggedinUser)
                            join v in db.Bookingcs
                            on e.CustomerID equals v.Cust_ID

                            select new { v.Tours, v.NumAdults, v.NumKids }).ToList();



                //foreach (var c in book)
                //{
                //    book.Add(new Bookingcs()
                //    {

                //        //BookingID = c.BookingID,
                       
                //    });
                //}
                return View(book);
            }
        }

        //    return View(db.Bookingcs.ToList());
        //}
        //public ActionResult SuccessPage()
        //{
        //    var booking = db.Bookingcs.Include(x => x.Tours.TourType);
        //    return View(db.Bookingcs.ToList());
        //}


        // GET: Bookingcs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookingcs bookingcs = db.Bookingcs.Find(id);
            if (bookingcs == null)
            {
                return HttpNotFound();
            }
            return View(bookingcs);
        }

        // GET: Bookingcs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bookingcs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID,Cust_ID,Tour_ID")] Bookingcs bookingcs)
        {
            if (ModelState.IsValid)
            {
                //var book1 = db.Bookingcs.Last();



                int bookingID = bookingcs.BookingID;
                //var book = db.Bookingcs.Last();                                                                                                                                                                                                                                                   
                int BookingId = bookingcs.BookingID; using (var dbs = new ParadiseDemo5Context())
                {
                    var change = dbs.Bookingcs.Where(x => x.BookingID == bookingID).ToList();
                    foreach (var item in change)
                    {
                        //item.TotalCost = item.TotalCost - (item.deposit + item.Discount);
                        dbs.SaveChanges();
                    }
                }

                db.Bookingcs.Add(bookingcs);
                db.SaveChanges();
                return RedirectToAction("SuccessPage");
            }

            return View(bookingcs);
        }

        // GET: Bookingcs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookingcs bookingcs = db.Bookingcs.Find(id);
            if (bookingcs == null)
            {
                return HttpNotFound();
            }
            return View(bookingcs);
        }

        // POST: Bookingcs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID,Cust_ID,Tour_ID")] Bookingcs bookingcs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingcs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingcs);
        }

        // GET: Bookingcs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookingcs bookingcs = db.Bookingcs.Find(id);
            if (bookingcs == null)
            {
                return HttpNotFound();
            }
            return View(bookingcs);
        }

        // POST: Bookingcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bookingcs bookingcs = db.Bookingcs.Find(id);
            db.Bookingcs.Remove(bookingcs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

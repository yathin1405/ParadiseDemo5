using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParadiseDemo5.Data;
using ParadiseDemo5.Models;

namespace ParadiseDemo5.Controllers
{
    public class UserToursController : Controller
    {
        private ParadiseDemo5Context db = new ParadiseDemo5Context();

        // GET: UserTours
        public ActionResult Index()
        {
            return View(db.UserTours.ToList());
        }

        // GET: UserTours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // GET: UserTours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID,CustomerID,CostOfBooking,DepositForBooking,BookingStatus,IsActive,PaymentMethod")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                //db.UserTours.Last();
                int tourid = userTour.BookingID;
                using (var dbs = new ParadiseDemo5Context())
                {
                    var change = dbs.Tours.Where(x => x.TourID == tourid).ToList();
                    foreach (var item in change)
                    {
                        item.capacity = item.capacity - (item.Num_Adults + item.Num_Kids);
                        dbs.SaveChanges();
                    }
                }


                //book-bookingID
                //
                //var userTour1= db.UserTours.Last();



                int bookingID = userTour.BookingID;



                var book = db.UserTours.Last();
                int Tourid = userTour.BookingID; using (var dbs = new ParadiseDemo5Context())
                {
                    var change = dbs.Tours.Where(x => x.TourID == tourid).ToList();
                    foreach (var item in change)
                    {
                        item.capacity = item.capacity - (item.Num_Adults + item.Num_Kids);
                                    dbs.SaveChanges();
                    }
                }
                db.UserTours.Add(userTour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userTour);
        }

        // GET: UserTours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID,CustomerID,CostOfBooking,DepositForBooking,BookingStatus,IsActive,PaymentMethod")] UserTour userTour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userTour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userTour);
        }

        // GET: UserTours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserTour userTour = db.UserTours.Find(id);
            if (userTour == null)
            {
                return HttpNotFound();
            }
            return View(userTour);
        }

        // POST: UserTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserTour userTour = db.UserTours.Find(id);
            db.UserTours.Remove(userTour);
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

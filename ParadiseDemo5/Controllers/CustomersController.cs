﻿using System;
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
    public class CustomersController : Controller
    {
        private ParadiseDemo5Context db = new ParadiseDemo5Context();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult SuccessPage()
        {
            return View(db.Bookingcs.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,LastName,contactNum,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //var book1 = db.Bookingcs.Last();

                int TourId= customer.CustomerID;
                //var book = db.Bookingcs.Last();
                int custrId = customer.CustomerID; using (var dbs = new ParadiseDemo5Context())
                {
                    var change = dbs.Customers.Where(x => x.CustomerID == custrId).ToList();
                    foreach (var item in change)
                    {
                        //item.TotalCost = item.TotalCost - (item.deposit + item.Discount);
                        dbs.SaveChanges();
                    }
                }

                int customerId = customer.CustomerID;
                ////var book = db.Bookingcs.Last();
                //int custrId = customer.CustomerID; using (var dbs = new ParadiseDemo5Context())
                //{
                //    var change = dbs.Customers.Where(x => x.CustomerID == custrId).ToList();
                //    foreach (var item in change)
                //    {
                //        //item.TotalCost = item.TotalCost - (item.deposit + item.Discount);
                //        dbs.SaveChanges();
                //    }
                //}
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("SuccessPage");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,LastName,contactNum,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
            {
                return HttpNotFound();
            }

            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // NOTE: Quote is NOT included in the Bind list so user cannot enter it.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Auto-calculate quote based on user inputs
                insuree.Quote = CalculateQuote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
            {
                return HttpNotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // NOTE: Quote is NOT included in the Bind list so user cannot edit it.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Recalculate quote on edit so it always matches current data
                insuree.Quote = CalculateQuote(insuree);

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Insuree insuree = db.Insurees.Find(id);

            if (insuree == null)
            {
                return HttpNotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);

            db.Insurees.Remove(insuree);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Insuree/Admin
        // Shows all quotes issued with FirstName, LastName, EmailAddress, and Quote
        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList();
            return View(insurees);
        }

        /// <summary>
        /// Calculates an insurance quote based on the assignment rules.
        /// </summary>
        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m; // Base quote

            // Calculate age correctly (covers all ages)
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            // Age rules
            if (age <= 18)
            {
                quote += 100m;
            }
            else if (age <= 25)
            {
                quote += 50m;
            }
            else
            {
                quote += 25m; // 26+
            }

            // Car year rules
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }
            if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            // Car make/model rules
            if (!string.IsNullOrWhiteSpace(insuree.CarMake) &&
                insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;

                if (!string.IsNullOrWhiteSpace(insuree.CarModel) &&
                    insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    quote += 25m; // additional (total Porsche + Carrera = +50)
                }
            }

            // Speeding tickets: +$10 each
            quote += insuree.SpeedingTickets * 10m;

            // DUI: +25%
            if (insuree.DUI)
            {
                quote *= 1.25m;
            }

            // Full coverage: +50%
            if (insuree.CoverageType)
            {
                quote *= 1.50m;
            }

            return Math.Round(quote, 2);
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

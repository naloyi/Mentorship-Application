using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using shanuMVCUserRoles.DataAccessLayer;
using shanuMVCUserRoles.Models;

namespace shanuMVCUserRoles.Controllers
{
    public class MenteeController : Controller
    {
        private Mentorship db = new Mentorship();

        // GET: Mentees
        public ActionResult Index()
        {
            var mentee = db.Mentee.Include(m => m.Administrator);
            return View(mentee.ToList());
        }

        // GET: Mentees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = db.Mentee.Find(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            return View(mentee);
        }

        // GET: Mentees/Create
        public ActionResult Create()
        {
            ViewBag.AdministratorID = new SelectList(db.Administrator, "AdministratorID", "Name");
            return View();
        }

        // POST: Mentees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MenteeID,FirstName,LastName,Email,Degree,CellPhoneNumber,PassWord,DateOfBirth,Points,Province,Rating,LearningInstitution,PreferredJobIndustry,PreferredWorkLocation,Status,AdministratorID")] Mentee mentee)
        {
            if (ModelState.IsValid)
            {
                db.Mentee.Add(mentee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdministratorID = new SelectList(db.Administrator, "AdministratorID", "Name", mentee.AdministratorID);
            return View(mentee);
        }

        // GET: Mentees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = db.Mentee.Find(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdministratorID = new SelectList(db.Administrator, "AdministratorID", "Name", mentee.AdministratorID);
            return View(mentee);
        }

        // POST: Mentees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MenteeID,FirstName,LastName,Email,Degree,CellPhoneNumber,PassWord,DateOfBirth,Points,Province,Rating,LearningInstitution,PreferredJobIndustry,PreferredWorkLocation,Status,AdministratorID")] Mentee mentee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdministratorID = new SelectList(db.Administrator, "AdministratorID", "Name", mentee.AdministratorID);
            return View(mentee);
        }

        // GET: Mentees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentee mentee = db.Mentee.Find(id);
            if (mentee == null)
            {
                return HttpNotFound();
            }
            return View(mentee);
        }

        // POST: Mentees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mentee mentee = db.Mentee.Find(id);
            db.Mentee.Remove(mentee);
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

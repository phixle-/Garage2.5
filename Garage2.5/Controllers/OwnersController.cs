//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Garage2._5.DataAccess;
//using Garage2._5.Models;

//namespace Garage2._5.Controllers
//{
//    public class OwnersController : Controller
//    {
//        private AppContext db = new AppContext();

//        // GET: Owners
//        public ActionResult Index()
//        {
//            var owners = db.Owners.Include(o => o.Person);
//            return View(owners.ToList());
//        }

//        // GET: Owners/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Owner owner = db.Owners.Find(id);
//            if (owner == null)
//            {
//                return HttpNotFound();
//            }
//            return View(owner);
//        }

//        // GET: Owners/Create
//        public ActionResult Create()
//        {
//            ViewBag.PersonId = new SelectList(db.People, "Id", "Name");
//            return View();
//        }

//        // POST: Owners/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "PersonId")] Owner owner)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Owners.Add(owner);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.PersonId = new SelectList(db.People, "Id", "Name", owner.PersonId);
//            return View(owner);
//        }

//        // GET: Owners/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Owner owner = db.Owners.Find(id);
//            if (owner == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.PersonId = new SelectList(db.People, "Id", "Name", owner.PersonId);
//            return View(owner);
//        }

//        // POST: Owners/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "PersonId")] Owner owner)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(owner).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.PersonId = new SelectList(db.People, "Id", "Name", owner.PersonId);
//            return View(owner);
//        }

//        // GET: Owners/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Owner owner = db.Owners.Find(id);
//            if (owner == null)
//            {
//                return HttpNotFound();
//            }
//            return View(owner);
//        }

//        // POST: Owners/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Owner owner = db.Owners.Find(id);
//            db.Owners.Remove(owner);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}

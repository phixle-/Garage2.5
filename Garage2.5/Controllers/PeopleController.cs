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
//using Garage2._5.Repositories;

//namespace Garage2._5.Controllers
//{
//    public class PeopleController : Controller
//    {

//        private SuperRepository repo = new SuperRepository();

//        public ActionResult BeOwn(int id)
//        {
//            repo.BecomeOwner(id);
//            return RedirectToAction("Details", new { id = id });
//        }

//        // GET: People
//        public ActionResult Index()
//        {
//            //var people = db.People.Include(p => p.Owner);
//            var people = repo.GetPeople();
//            if (people.Any())
//                return View(people.ToList());
//            else
//                return Content("Finns inge folk här");
//        }

//        // GET: People/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Person person = repo.FindPersonById(id);
//            if (person == null)
//            {
//                return HttpNotFound();
//            }
//            return View(person);
//        }

//        // GET: People/Create
//        public ActionResult Create()
//        {
//            ViewBag.Id = new SelectList(repo.GetAllOwners(), "PersonId", "PersonId");
//            return View();
//        }

//        // POST: People/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,PNR,Name")] Person person)
//        {
//            if (ModelState.IsValid)
//            {
//                repo.AddPerson(person);
//                return RedirectToAction("Index");
//            }

//            ViewBag.Id = new SelectList(repo.GetAllOwners(), "PersonId", "PersonId", person.Id);
//            return View(person);
//        }

//        // GET: People/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Person person = repo.FindPersonById(id);
//            if (person == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.Id = new SelectList(repo.GetAllOwners(), "PersonId", "PersonId", person.Id);
//            return View(person);
//        }

//        // POST: People/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,PNR,Name")] Person person)
//        {
//            if (ModelState.IsValid)
//            {
//                repo.UpdatePerson(person);
//                return RedirectToAction("Index");
//            }
//            ViewBag.Id = new SelectList(repo.GetAllOwners(), "PersonId", "PersonId", person.Id);
//            return View(person);
//        }

//        // GET: People/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Person person = repo.FindPersonById(id);
//            if (person == null)
//            {
//                return HttpNotFound();
//            }
//            return View(person);
//        }

//        // POST: People/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Person person = repo.FindPersonById(id);
//            repo.RemovePerson(person);
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                repo.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}

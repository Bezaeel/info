using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using info.Models;

namespace info.Controllers
{
    public class wardInfoController : Controller
    {
        private infoContext db = new infoContext();

        // GET: wardInfo
        public ActionResult Index()
        {
            return View(db.wardInfoes.ToList());
        }

        // GET: wardInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wardInfo wardInfo = db.wardInfoes.Find(id);
            if (wardInfo == null)
            {
                return HttpNotFound();
            }
            return View(wardInfo);
        }

        // GET: wardInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: wardInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,work,phone,email,twitter")] wardInfo wardInfo)
        {
            if (ModelState.IsValid)
            {
                db.wardInfoes.Add(wardInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wardInfo);
        }

        // GET: wardInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wardInfo wardInfo = db.wardInfoes.Find(id);
            if (wardInfo == null)
            {
                return HttpNotFound();
            }
            return View(wardInfo);
        }

        // POST: wardInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,work,phone,email,twitter")] wardInfo wardInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wardInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wardInfo);
        }

        // GET: wardInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            wardInfo wardInfo = db.wardInfoes.Find(id);
            if (wardInfo == null)
            {
                return HttpNotFound();
            }
            return View(wardInfo);
        }

        // POST: wardInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            wardInfo wardInfo = db.wardInfoes.Find(id);
            db.wardInfoes.Remove(wardInfo);
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

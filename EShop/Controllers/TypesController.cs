﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using EShop.Data;
//using EShop.Models;
//using TypeModel = EShop.Models.TypeModel;

//namespace EShop.Controllers
//{
//    public class TypesController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        // GET: Types
//        public ActionResult Index()
//        {
//            return View(db.Types.ToList());
//        }

//        // GET: Types/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            TypeModel type = db.Types.Find(id);
//            if (type == null)
//            {
//                return HttpNotFound();
//            }
//            return View(type);
//        }

//        // GET: Types/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Types/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Name")] TypeModel type)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Types.Add(type);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(type);
//        }

//        // GET: Types/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            TypeModel type = db.Types.Find(id);
//            if (type == null)
//            {
//                return HttpNotFound();
//            }
//            return View(type);
//        }

//        // POST: Types/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Name")] TypeModel type)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(type).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(type);
//        }

//        // GET: Types/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            TypeModel type = db.Types.Find(id);
//            if (type == null)
//            {
//                return HttpNotFound();
//            }
//            return View(type);
//        }

//        // POST: Types/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            TypeModel type = db.Types.Find(id);
//            db.Types.Remove(type);
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

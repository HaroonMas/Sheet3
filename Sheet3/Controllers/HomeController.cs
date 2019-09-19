using Entities;
using Sheet3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DBManager db = new DBManager();
            var records = db.getAll();
            return View(records);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    
    [HttpPost]
        public ActionResult Create(Contact p)
    {
        DBManager db = new DBManager();
        db.Add(p);
            return RedirectToAction("index");
    }
        public ActionResult Details(int id)
        {
            DBManager db = new DBManager();
            var currentRecord = db.Details(id);
            return View(currentRecord);
        }

        public ActionResult Delete(int id)
        {
            DBManager db = new DBManager();
            db.Delete(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            DBManager db = new DBManager();
            var record = db.Details(id);
            return View();
        }

        [HttpPost]
    public ActionResult Edit(Contact c)
    {
        DBManager db = new DBManager();
        db.Update(c);
        return RedirectToAction("index");
    }
}
}
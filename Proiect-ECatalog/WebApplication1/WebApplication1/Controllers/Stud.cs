using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Stud : Controller
    {
        private readonly AppDbContext _db;

        public Stud(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Info> objList = _db.Information;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Info obj)
        {
            if(ModelState.IsValid)
            {
                _db.Information.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            var obj = _db.Information.Find(id);
            if(obj==null)
            {
                return NotFound();
            }
                _db.Information.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }
        public IActionResult Update(int? id)
        {
            var obj = _db.Information.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Info obj)
        {
            if (ModelState.IsValid)
            {
                _db.Information.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EMMARKET.Models;

namespace EMMARKET.Controllers
{
    public class CategoriesController : Controller
    {
        private StoreEntities db = new StoreEntities();

        
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        
        

       
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cid,name,number_of_products")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

       
      

        
      
        }

       
        

       

        
    }


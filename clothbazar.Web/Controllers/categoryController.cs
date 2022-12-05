using cloothbazaar.entities;
using clothbazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clothbazar.Web.Controllers
{
    public class categoryController : Controller
    {
        CategriousService catryservice = new CategriousService();


        // GET: category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Catregry catregry)
        {

            catryservice.SaveCategory(catregry);
            return View();
        }
    }
}
using cloothbazaar.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clothbazar.Web.Controllers
{
    public class categoryController : Controller
    {
        // GET: category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(catregry Catregry )
        {
            return View();
        }
    }
}
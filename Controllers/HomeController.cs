using JqueryDatatable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDatatable.Controllers
{
    public class HomeController : Controller
    {
        JquerdataEntities1 db = new JquerdataEntities1();
        public ActionResult Index()
        {
            var data  = db.loadings.ToList();
            return View(data);
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCeTicaret.Models;

namespace MVCeTicaret.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            Context db = new Context();

            //guid.newguid=> linq da karıştırıp verir bize verileri.TAKE ile de kaç tanesini istersek o kadarını verir
            TempData["KADIN"] = db.Products.Where(x => x.SubCategoryID == 1).OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            TempData["ERKEK"] = db.Products.Where(x => x.SubCategoryID == 2).OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            TempData["ÇOCUK"] = db.Products.Where(x => x.SubCategoryID == 3).OrderBy(x => Guid.NewGuid()).Take(4).ToList();

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCeTicaret.Models;

namespace MVCeTicaret.Controllers
{
    public class ProfileController : Controller
    {
        Context db;
        public ProfileController()
        {
            db = new Context();
        }

        // GET: Profile  //birşey yazmazsa get işlemi yapar
        public ActionResult UpdateProfile()
        {
            return View(db.Customers.Find(TemporaryUserData.UserID));
        }

        [HttpPost]
        public ActionResult UpdateProfile(FormCollection frm)
        {
            /*adını soyadını
             * kullanıcı adını sadece gorsun
             * parolasını 
             * cinsiyetini
             * doğum tarihini
             adresini
             sehrini
             ülkesini güncelleyebilsin
             */
            Customer customer = db.Customers.Find(TemporaryUserData.UserID);

            customer.FirstName = frm["FirstName"];
            customer.LastName = frm["LastName"];
            customer.Password = frm["Password"];
            customer.Gender = frm["Gender"] =="false" ? false:true;
            customer.BirthDate = DateTime.Parse(frm["BirthDate"]);
            customer.Address = frm["Address"];
            customer.City = frm["City"];
            customer.Country = frm["Country"];

            db.SaveChanges();
            return RedirectToAction("ProfileUpdated","Profile");
        }

        public ActionResult ProfileUpdated()
        {
            return View();
        }
    }
}
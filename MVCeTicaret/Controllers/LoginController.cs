using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCeTicaret.Models;

namespace MVCeTicaret.Controllers
{
    public class LoginController : Controller
    {
        Context db;

        public LoginController()
        {
            db = new Context();
        }


        [HttpGet]
        public ActionResult Login()
        {
            TemporaryUserData.ReturnUrl = System.Web.HttpContext.Current.Request.UrlReferrer.ToString();

            return View();
        }


        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            string kullaniciAdi = frm["username"];
            string sifre = frm["password"];

            Customer customer = db.Customers.FirstOrDefault(x => x.UserName == kullaniciAdi && x.Password == sifre);

            if (customer != null)
            {
                Session["OnlineKullanici"] = customer.UserName;
                TemporaryUserData.UserID = customer.CustomerID;


                //kullanıcı varsa anasayfaya gideecek üye ekranı açılmayacak
                if (TemporaryUserData.ReturnUrl.Contains("Register"))
                    return RedirectToAction("Index", "Home");

                return Redirect(TemporaryUserData.ReturnUrl);
            }

            return View();
        }

        public ActionResult Logout()
        {
            db.Customers.Find(TemporaryUserData.UserID).LastLogin = DateTime.Now;
            db.SaveChanges();
            Session["OnlineKullanici"] = null;
            TemporaryUserData.UserID = 0;


            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            TemporaryUserData.ReturnUrl = System.Web.HttpContext.Current.Request.UrlReferrer.ToString();

            return View();
        }


        [HttpPost]
        public ActionResult Register(FormCollection frm)
        {
            string kullaniciAdi = frm["username"];
            Customer customer = db.Customers.FirstOrDefault(x => x.UserName == kullaniciAdi);

            if (customer != null)
                    return View();
             else
             {
                customer = new Customer();
                customer.FirstName = frm["name"];
                customer.LastName = frm["surname"];
                customer.UserName = kullaniciAdi;
                customer.Password = frm["password"];
                customer.Gender = frm["gender"] == "on" ? true : false;
                customer.BirthDate = DateTime.Parse(frm["birthdate"]);
                customer.CreateDate = DateTime.Now;
                customer.LastLogin = DateTime.Now;

                db.Customers.Add(customer);
                db.SaveChanges();

                Session["OnlineKullanici"] = kullaniciAdi;
                TemporaryUserData.UserID = customer.CustomerID;

                return Redirect(TemporaryUserData.ReturnUrl);                
            }
        }
    }
}
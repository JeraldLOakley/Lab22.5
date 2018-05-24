using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                    
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login(string UserName = "", string FavoriteColor = "")
        {
            ViewBag.FavoriteColor = FavoriteColor;
            ViewBag.UserName = UserName;
            //ViewBag.Food = FavoriteFood;
            if (Session["UserName"] == null && Session["FavoriteColor"] == null)
            {
                Session.Add("FavoriteColor", ViewBag.FavoriteColor);
                Session.Add("UserName", ViewBag.UserName );
                //Session.Add("Food", ViewBag.Food);
            }
            UserName = (string)Session["UserName"];
            Session["UserName"] = UserName;

            FavoriteColor = (string)Session["FavoriteColor"];
            Session[FavoriteColor] = FavoriteColor;

            //Food = (string)Session["Food"];
            //Session["Food"] = Food;
            return View();
        }
    }
}
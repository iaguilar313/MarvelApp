using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieClub()
        {
            return View();
        }

        public ActionResult BuyTickets()
        {
            return View();
        }


        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.status = "What's the best Marvel Movie?";

            Random r = new Random();

            int choice = r.Next(1, 5);

            if (choice == 1)
                ViewBag.Health = "Guardians of the Galaxy";
            else if (choice == 2)
                ViewBag.Health = "Ant MAN";
            else if (choice == 3)
                ViewBag.Health = "Avengers";
            else
                ViewBag.Health = "DC COmics are BETTER";

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.TodaysDate = DateTime.Now;//servers time 

            //anything you want to make relatd to the clienet you need to make java script

            //AJAX 

            return View();
        }

        public ActionResult ProcessForm(UserInfo UserData)
        {
            // add this object to the db!

            // viewbag sends infomraiton from controller to the view 
            ViewBag.ClientName = UserData.ClientName;
            ViewBag.ClientEmail = UserData.Email;

            return View("Confirm");



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Net_Project.Models;

namespace MVC_Net_Project.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        // GET: Home
        
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }
    }
}
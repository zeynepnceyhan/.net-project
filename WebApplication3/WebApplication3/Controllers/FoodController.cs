using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        Context db = new Context();
        public ActionResult Index()
        {
            List<Food> FoodList = db.Foods.ToList();
            return View(FoodList);
        }
    }
}
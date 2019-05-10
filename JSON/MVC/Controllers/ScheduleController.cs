using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ScheduleController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: Schedule
        public ActionResult Index(int year = 2019)
        {
            var date = db.FootballSchedules.Where(x => x.Season == year);
            return View(date);
        }
    }
}
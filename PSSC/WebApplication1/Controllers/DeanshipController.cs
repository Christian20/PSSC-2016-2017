using Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DeanshipController : Controller
    {
        //
        // GET: /Deanship/
        public ActionResult Index()
        {
            return View();
        }

       // [HttpPost]
        public ActionResult Student(Student obj)
        {
            ViewBag.Name = "The student exists";
            return View();
        }
	}
}
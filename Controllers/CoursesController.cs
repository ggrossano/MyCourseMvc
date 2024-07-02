using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetService();
            return View(courses);
        }
        public IActionResult Detail(string id)
        {
            /* return Content($"Sono content con id: {id}"); */
            return View();
        }

    }
}
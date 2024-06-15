using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using aspnet_education_part1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnet_education_part1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Course 1";
            course.Description = "Course 1 description";
            return View(course);
        }
        public IActionResult List()
        {
            var courses = new List<Course>(){
                new Course(){ Id = 1, Title = "Course 1", Description = "Course 1 Description", Image = "1.jpg"},
                new Course(){ Id = 2, Title = "Course 2", Description = "Course 2 Description", Image = "2.jpg"},
                new Course(){ Id = 3, Title = "Course 3", Description = "Course 3 Description", Image = "3.jpg"},
            };
            return View(courses);
        }
    }
}
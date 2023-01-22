using Microsoft.AspNetCore.Mvc;
using mission5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission5.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeCalculator(Grade Grade)
        {
            // check if the model has appropriate data
            if (ModelState.IsValid)
            {
                // create a new grade instance from the form
                Grade NewGrade = Grade;

                //return the result to the GradeCalculator view
                return RedirectToAction(
                    "GradeCalculator", 
                    "Home",
                    new { 
                        Grade = NewGrade.NumericGrade,
                        Letter = NewGrade.LetterGrade,
                        Assignments = NewGrade.Assignments,
                        GroupProjects = NewGrade.GroupProjects,
                        Quizzes = NewGrade.Quizzes,
                        Midterm = NewGrade.Midterm,
                        Final = NewGrade.Final,
                        Intex = NewGrade.Intex
                    }
                );
            }
            return View();
        }
    }
}

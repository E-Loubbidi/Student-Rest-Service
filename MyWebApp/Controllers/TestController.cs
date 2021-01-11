using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MyWebApp.Model;

namespace MyWebApp.Controllers{
    public class TestController:Controller {
        public IActionResult Index(){
            IList<string> items = new List<string>();
            items.Add("Mohamed");items.Add("Hassan");items.Add("Ines");
            ViewData["email"] = "mohamed@gmail.com";
            ViewBag.contact = "enset@univh2c.ac.ma";
            return View(items);
        }

        public IActionResult List(){
            IList<Student> students = new List<Student>();
            students.Add(new Student{Id=1,Name="Morad",Score=59});
            students.Add(new Student{Id=2,Name="Salme",Score=45});
            students.Add(new Student{Id=3,Name="Mohamed",Score=71});
            return View(students);
        }

        public IActionResult A(){
            return View();
        }
        public IActionResult B(){
            return View("BB");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice.Data;
using Practice.Models;

namespace Practice.Controllers
{
    public class StudentAccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentAccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // get student Det
        public static List<StudentAccount> studentAccounts = new List<StudentAccount>()
        { 
          new StudentAccount() { Id = 1,Name="Anjali",Fee=20000}
        };


        public IActionResult Index()
        {
            ViewBag.Message = "Student Details";
            ViewBag.studentList = studentAccounts;
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class FormController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }


        // strongly 

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View();
        }
        // user details page
        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "Anjali",
                Password = "1234"
            };
            return View(user);
        }

    }
}

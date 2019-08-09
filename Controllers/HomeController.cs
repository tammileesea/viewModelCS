using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModel.Models;

namespace viewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            string myString = "WHAT is this NonSEnSe!!!!";
            return View("Index", myString);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers(){
            int[] numbs = new int[] {2, 4, 6, 8};
            return View("Numbers", numbs);
        }

        [HttpGet("users")]
        public IActionResult Users(){
            string[] names = new string[]{
                "sally", "billy", "joey", "moose"
            };
            return View("Users", names);
        }

        [HttpGet("user")]
        public IActionResult User(){
            User user1 = new User(){
                FirstName = "Tam",
                LastName = "Lee"
            };
            return View("User", user1);
        }
    }
}

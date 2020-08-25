﻿using Microsoft.AspNetCore.Mvc;

namespace WebChatSocket.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("InsertUserName");
        }

        [HttpPost]
        public IActionResult Index(string username)
        {
            return View("Index", username);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

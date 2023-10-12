﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http; //- Session 4 

using LoginRegister.Models;

using Microsoft.AspNetCore.Http;

namespace LoginRegister.Controllers;

public class HomeController : Controller
{
    private MyContext _context;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("users/create")]
    public IActionResult Register(User newUser)
    {
        if (ModelState.IsValid)
        {
            // Email Exist ?
            if (_context.Users.Any(u => u.Email == newUser.Email))
            {
                // True
                ModelState.AddModelError("Email", "Email already in use .");
                return View("Index");
            }
            else
            {
                // False
                // 1 - Hash Password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                // 2 - Add 
                _context.Add(newUser);
                // 3 - Save
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                HttpContext.Session.SetString("username", newUser.FirstName);
                // HttpContext.Session.
                return RedirectToAction("Privacy");
            }
        }
        return View("Index");
    }
    public IActionResult Privacy()
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("Index");
        }
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        User? user = _context.Users.FirstOrDefault(u => u.UserId == userId);
        return View(user);
    }
    [HttpPost("users/login")]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid)
        {
            // User Registered ?
            User? userFromDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
            if (userFromDb is null)
            {
                ModelState.AddModelError("LoginEmail", "Email dose not exist !");
                return View("Index");
            }
            else
            {
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(loginUser, userFromDb.Password, loginUser.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Wrong Password !");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("userId", userFromDb.UserId);
                    HttpContext.Session.SetString("username", userFromDb.FirstName);
                    return RedirectToAction("Privacy");
                }
            }
        }
        return View("Index");


    }
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

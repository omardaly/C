using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.controllers;

public class First : Controller
{
[HttpGet("")]
public ViewResult Dashboard()
{
    return View("Dashboard");
}
[HttpPost("process")]
public ViewResult Result(string name,string location,string language,string comment )
{
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
       System.Console.WriteLine("this is my comment %%%%%%%%%%%",comment);
        return View ("Result");
}
}
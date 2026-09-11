using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // public string Index()
    // {
    //     return "This is my default action...";
    // }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 2)
    {
        // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    // public string Welcome()
    // {
    //     return "This is the Welcome action method...";
    // }
    public IActionResult Privacy()
    {
        return View();
    }
}
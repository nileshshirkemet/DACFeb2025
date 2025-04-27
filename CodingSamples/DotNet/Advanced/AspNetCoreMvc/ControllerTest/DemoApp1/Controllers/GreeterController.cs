using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class GreeterController : Controller
{
    //this method will handle GET request for /Greeter/Clock
    public IActionResult Clock()
    {
        return Content(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
    }

    public IActionResult Greet(string id, [FromServices] IVisitCounter counter)
    {
        var info = new 
        {
            VisitorName = id,
            GreetCount = counter.NextCount(id)
        };
        string browser = Request.Headers.UserAgent;
        if(browser.Contains("Mobile"))
            return View("~/Views/Hello.cshtml", info);
        return View("~/Views/Welcome.cshtml", info);
    }
}

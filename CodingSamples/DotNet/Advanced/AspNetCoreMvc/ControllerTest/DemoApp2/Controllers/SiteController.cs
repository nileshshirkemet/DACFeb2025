using DemoApp.Tourism.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoApp.Controllers;

[ApiController]
public class SiteController : ControllerBase
{
    [HttpGet("/api/site")]
    public IActionResult ReadVisitors(SiteModel model)
    {
        var visitors = model.GetVisitors();
        if(visitors.Any())
            return Ok(visitors);
        return NotFound();
    }

    [HttpPost("/api/site")]
    public IActionResult WriteVisitor(Feedback input, SiteModel model)
    {
        model.AcceptVisit(input.Person, input.Rating);
        return Ok();
    }
}
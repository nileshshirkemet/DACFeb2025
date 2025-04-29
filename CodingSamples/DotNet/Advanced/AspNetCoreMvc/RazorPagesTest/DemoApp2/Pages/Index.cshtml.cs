using System.Security.Claims;
using DemoApp.Data.Shopping;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Pages;

class Index(ShopDbContext shop) : PageModel
{
    [BindProperty]
    public Customer Login { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        int count = await shop.Customers
            .Where(c => c.UserName == Login.UserName && c.Password == Login.Password)
            .CountAsync();
        if(count == 1)
        {
            var identity = new ClaimsIdentity("Customer");
            identity.AddClaim(new Claim(ClaimTypes.Name, Login.UserName));
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return RedirectToPage("Detail");
        }
        ModelState.AddModelError("Login", "Invalid Customer ID or Password");
        return Page();
    }

}
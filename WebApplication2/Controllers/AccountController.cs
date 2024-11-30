using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        return View();
    }


    //Post Method

    [HttpPost]
    public async Task<IActionResult> Register(User user)
    {
        if (ModelState.IsValid)
        {
            _context.Add(user); 
            await _context.SaveChangesAsync();  // Save changes to the database
            return RedirectToAction("Register");  
        }
        return View(user);  
    }
}

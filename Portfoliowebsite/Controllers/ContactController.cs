using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Models;
using Portfoliowebsite.Services;

namespace Portfoliowebsite.Controllers;

public class ContactController : Controller
{
    private readonly IEmailSender _email;
    public ContactController(IEmailSender email) => _email = email;

    [HttpGet]
    public IActionResult Index() => View(new ContactFormViewModel());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ContactFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        await _email.SendAsync(model.Name, model.Email, model.Subject, model.Message);
        TempData["ThanksName"] = model.Name;
        return RedirectToAction(nameof(Thanks));
    }

    [HttpGet]
    public IActionResult Thanks() => View();
}

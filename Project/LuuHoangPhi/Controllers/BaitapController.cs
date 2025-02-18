using Microsoft.AspNetCore.Mvc;
using Models;

namespace LuuHoangPhi.Controllers;
public class BaitapController : Controller
{
    public IActionResult Index()
    {
       return View();
    }
    [HttpPost]
    public IActionResult Index(Person person)
    {
        ViewBag.message = $"Xin chào {person.FullName} có Id : {person.PersonId} có địa chỉ : {person.Address} ";
        return View();
    }
}
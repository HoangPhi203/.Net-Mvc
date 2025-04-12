using Microsoft.AspNetCore.Mvc;

namespace LuuHoangPhi.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Index(string name, string address)
    {
        var message = "Xin chào " + name + "sống ở " + address;
        ViewBag.Message = message;
        return View();
    }
}

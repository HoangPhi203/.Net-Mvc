using Microsoft.AspNetCore.Mvc;

namespace LuuHoangPhi.Controllers;
public class DemoController : Controller
{
    public IActionResult Student()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Student(string name, string address )
    {
    string Message ="Họ và tên" + name + "Dịa chỉ" + address;
    ViewBag.Message = Message;
    return View();
    }
}
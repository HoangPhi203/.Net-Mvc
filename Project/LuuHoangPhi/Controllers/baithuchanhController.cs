using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Models;

namespace LuuHoangPhi.Controllers;
public class baithuchanhController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(int CanNang, int ChieuCao,Person person)
    {
        var result =CanNang/((ChieuCao/100)*(ChieuCao/100));
        ViewBag.message = $"Xin chào {person.FullName} {person.Tuoi} tuổi có chiều cao: {person.ChieuCao} cm và cân nặng: {person.CanNang} kg Chỉ sô BMI là: {result}";
        return View();
    }
    [HttpPost]
    public IActionResult Index(double DiemA, double DiemB, double DiemC, Person person)
    {
        var dtp =(DiemA*0.6)+(DiemB*0.3)+(DiemC*0.1);
        ViewBag.message =$"Điểm thành phần của bạn là: {person.DiemA} {person.Diem} {person.DiemC} {dtp}";
        return View();
    }
}
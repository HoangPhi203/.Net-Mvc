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
    public IActionResult Index( Person person)
    {
        var result =person.CanNang/((person.ChieuCao/100)*(person.ChieuCao/100));
        var dtb =(person.DiemA*0.6)+(person.DiemB*0.3)+(person.DiemC*0.1);
        var ThanhTien =person.GiaCa*person.SoLuong;
        if(dtb<5){
            ViewBag.dtb1 =$"Bạn : {person.FullName} có điểm trung bình là: {dtb} ,bạn được bằng trung bình";
        }
        else
        if(dtb>5 && dtb<6.5){
            ViewBag.dtb1 =$"Bạn : {person.FullName} có điểm trung bình là: {dtb}, bạn được bằng khá";
        }
        else
        if(dtb>=6.5 && dtb<8){
            ViewBag.dtb1 =$"Bạn : {person.FullName} có điểm trung bình là: {dtb}, bạn được bằng giỏi";
        }
        ViewBag.message = $"Xin chào {person.FullName} {person.Tuoi} tuổi có chiều cao: {person.ChieuCao} cm và cân nặng: {person.CanNang} kg Chỉ sô BMI là: {result}";
        ViewBag.dtb = $"Điểm A: {person.DiemA} Điểm B: {person.DiemB} Điểm C: {person.DiemC} DTB là : {dtb}";
        ViewBag.ThanhTien =$" Tên Sản phẩm: {person.TenSP} Giá cả: {person.GiaCa} Số lượng: {person.SoLuong} Tổng thành tiền là: {ThanhTien}  ";
        return View();
    }
   
}
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
    public IActionResult Index( Baithuchanh baithuchanh)
    {
        var result =baithuchanh.CanNang/((baithuchanh.ChieuCao/100)*(baithuchanh.ChieuCao/100));
        var dtb =(baithuchanh.DiemA*0.6)+(baithuchanh.DiemB*0.3)+(baithuchanh.DiemC*0.1);
        var ThanhTien =baithuchanh.GiaCa*baithuchanh.SoLuong;
        if(dtb<5){
            ViewBag.dtb1 =$"Bạn : {baithuchanh.FullName} có điểm trung bình là: {dtb} ,bạn được bằng trung bình";
        }
        else
        if(dtb>5 && dtb<6.5){
            ViewBag.dtb1 =$"Bạn : {baithuchanh.FullName} có điểm trung bình là: {dtb}, bạn được bằng khá";
        }
        else
        if(dtb>=6.5 && dtb<8){
            ViewBag.dtb1 =$"Bạn : {baithuchanh.FullName} có điểm trung bình là: {dtb}, bạn được bằng giỏi";
        }
        ViewBag.message = $"Xin chào {baithuchanh.FullName} {baithuchanh.Tuoi} tuổi có chiều cao: {baithuchanh.ChieuCao} cm và cân nặng: {baithuchanh.CanNang} kg Chỉ sô BMI là: {result}";
        ViewBag.dtb = $"Điểm A: {baithuchanh.DiemA} Điểm B: {baithuchanh.DiemB} Điểm C: {baithuchanh.DiemC} DTB là : {dtb}";
        ViewBag.ThanhTien =$" Tên Sản phẩm: {baithuchanh.TenSP} Giá cả: {baithuchanh.GiaCa} Số lượng: {baithuchanh.SoLuong} Tổng thành tiền là: {ThanhTien}  ";
        return View();
    }
   
}
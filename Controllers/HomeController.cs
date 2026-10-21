using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SHOP.Models;

namespace SHOP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    
    {
        return View();
    }
     public IActionResult Gioithieu()
    {
        var sanpham = new List<Sanpham>
        {
            new Sanpham { Id = 1, Ten = "Sản phẩm 1", Mota = "Mô tả sản phẩm 1", Gia = 100000, Hinhanh = "sanpham1.jpg" },
            new Sanpham { Id = 2, Ten = "Sản phẩm 2", Mota = "Mô tả sản phẩm 2", Gia = 200000, Hinhanh = "sanpham2.jpg" },
            new Sanpham { Id = 3, Ten = "Sản phẩm 3", Mota = "Mô tả sản phẩm 3", Gia = 300000, Hinhanh = "sanpham3.jpg" }
        };
        return View(sanpham);
    }
    public IActionResult Nhacungcap()
    {
        var tennhacungcap = new List<Tennhacungcap>
        {
            new Tennhacungcap { Id = 1, Ten = "Nhà cung cấp 1", Diachi = "Địa chỉ 1", Sdt = "0123456789" },
            new Tennhacungcap { Id = 2, Ten = "Nhà cung cấp 2", Diachi = "Địa chỉ 2", Sdt = "0123456789" },
            new Tennhacungcap { Id = 3, Ten = "Nhà cung cấp 3", Diachi = "Địa chỉ 3", Sdt = "0123456789" }
        };
        return View(tennhacungcap);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

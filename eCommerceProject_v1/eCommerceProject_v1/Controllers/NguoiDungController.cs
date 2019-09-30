using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceProject_v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject_v1.Controllers
{
    public class NguoiDungController : Controller
    {
        private readonly  QLBH_v2019Context _ctx;

        public NguoiDungController(QLBH_v2019Context ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(ModelViewLogin modelLogin)
        {
            if (ModelState.IsValid)
            {
                NguoiDung userLogin = _ctx.NguoiDung.SingleOrDefault(p => p.Email == modelLogin.Email && p.Matkhau == Encryptor.MD5Hash(modelLogin.Password));
                if (userLogin == null)
                {
                    ModelState.AddModelError("loi", "Tên đăng nhập hoặc mật khẩu không hợp lệ.");
                    return View("Index");
                }
                else
                {
                    if (userLogin.Trangthaihd == true)
                    {
                        HttpContext.Session.Set("user", userLogin);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("loi", " Tài khoản bạn chưa được kích hoạt, vui lòng kiểm tra mail để kích hoạt tài khoản");
                        return View("Index");
                    }
                }
            }
            return View(); 
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index");
        }
    }
} 
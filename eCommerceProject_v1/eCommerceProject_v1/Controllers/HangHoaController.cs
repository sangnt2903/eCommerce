using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceProject_v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject_v1.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly QLBH_v2019Context _ctx;

        public HangHoaController(QLBH_v2019Context ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
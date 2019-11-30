using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Quản_lý_Sinh_viên.Controllers
{
    public class LopHocPhanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
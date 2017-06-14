using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GUISUVVueComponent.Controllers
{
    public class VUETestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("addperson")]
        public IActionResult AddPerson(string Name,string Sex,int Age,string mz,double height)
        {
            return new JsonResult(new { name = Name, sex = Sex, age = Age,mz=mz, height = height });
        }


        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
        [HttpPost("savadata")]
        public bool SavaData(List<object> data)
        {
            return true;
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }
    }
}

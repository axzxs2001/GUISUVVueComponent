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
        public IActionResult AddPerson(string name,string sex,int age,string mz,double height)
        {
            return new JsonResult(new { name = name, sex = sex, age = age,mz=mz, height = height });
        }


        public IActionResult Index2()
        {
            return View();
        }
    }
}

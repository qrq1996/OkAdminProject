using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeApiController : Controller
    {
        public JsonResult Login(string username,string password)
        {
            //if(username=="111111")
            return Json(new { code=0});
        }
        public JsonResult UserList()
        {
            //if(username=="111111")
            return Json(new { code = 0,msg= "查询用户成功" });
        }

    }
}

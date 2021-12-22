using ApiTest.Authentication;
using ApiTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MemberController : Controller
    {
        private readonly JwtHelper _jwtHelper;

        public MemberController(JwtHelper jwtHelper)
        {
            _jwtHelper = jwtHelper;
        }
        
        [HttpPost]
        [ValidateModelAttribute]
        public IActionResult Register(MemberRegisterReq request)
        {
            return Ok();
        }

        [HttpPost]
        [ValidateModelAttribute]
        public IActionResult Login(MemberLoginReq request)
        {
            if (ValidateUser(request))
                return Json(_jwtHelper.GenerateToken(request.account));
            else
                return BadRequest();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Page()
        {
            var name = User.Identity.Name;
            return Ok(name+"已登入");
        }

        private bool ValidateUser(MemberLoginReq data)
        {
            return true;
        }
    }
}

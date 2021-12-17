using ApiTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestRequireController : ControllerBase
    {
        [HttpPost]
        [ValidateModelAttribute]
        public IActionResult Register(RegisterMemberReq req)
        {
            return Ok();
        }
    }
}

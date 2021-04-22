using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        [HttpGet]
        [Route("GetUserData")]
        [Authorize]
        public IActionResult GetUserData()
        {
            return Ok("This is an Employee user");
        }

        [HttpGet]
        [Route("GetAdminData")]
        [Authorize]
        public IActionResult GetAdminData()
        {
            return Ok("This is an Admin user");
        }
    }
}

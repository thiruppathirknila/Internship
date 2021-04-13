//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Token_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public IEnumerable<string> Get()
            => new string[] { "John" , "Sam" };
    }
}

using Employee_Management1.Models;
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
    public class ApplyLeaveController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public ApplyLeaveController(EmployeeContext context)
        {
            _context = context;
        }

    }
}

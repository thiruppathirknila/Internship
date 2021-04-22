using Employee_Management1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        // GET: api/ApplyLeave
        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<ActionResult<IEnumerable<ApplyLeave>>> GetApplyLeave()
        {
            return await _context.Leaves.ToListAsync();
        }
        //POST:api/ApplyLeave
        [HttpPost]
        public async Task<IActionResult> PostLeave(ApplyLeave applyleave)
        {
            _context.Leaves.Add(applyleave);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetApplyLeave", new { id = applyleave.Id }, applyleave);
        }
    }
}

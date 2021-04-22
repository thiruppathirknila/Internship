//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Token_Product.Models;

//namespace Token_Product.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class InvoiceController : ControllerBase
//    {
//        private readonly ProductContext _context;

//        public InvoiceController(ProductContext context)
//        {
//            _context = context;
//        }

//        // GET: api/UserProfile
//        [HttpGet]
//        //[Microsoft.AspNetCore.Authorization.Authorize]
//        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoice()
//        {
//            return await _context.Invoices.ToListAsync();
//        }

//        [HttpPost("PostInvoice")]
//        public async Task<IActionResult> PostInvoice(Invoice invoice)
//        {
//            _context.Invoices.Add(invoice);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetCustomer", new { id = invoice.CustomerId }, invoice);
//        }
//    }
//}

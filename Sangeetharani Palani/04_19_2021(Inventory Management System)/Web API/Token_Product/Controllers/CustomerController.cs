using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Token_Product.Models;

namespace Token_Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ProductContext _context;

        public CustomerController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/UserProfile
        [HttpGet("GetCustomer")]
        //[Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return await _context.Customers.ToListAsync();
        }


        [HttpGet("GetCustomer/{id}")]
        public async Task<ActionResult<Customer>> cc(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }




        [HttpPost]
        public async Task<IActionResult> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.Customer_Id }, customer);
        }
        // POST: api/UserProfile/PostProduct
        //[HttpPost("PostCustomer")]
        //public async Task<IActionResult> PostCustomer(Customer customer)
        //{
        //    if (customer.Customer_Id == 0)
        //    {
        //        _context.Customers.Add(customer);
        //    }
        //    else
        //    {
        //        _context.Entry(customer).State = EntityState.Modified;
        //    }
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomer", new { id = customer.Customer_Id }, customer);
        //}




    }
}

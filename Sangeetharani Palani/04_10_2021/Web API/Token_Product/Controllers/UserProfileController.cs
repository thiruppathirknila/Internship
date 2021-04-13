//using Microsoft.AspNetCore.Authorization;
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
    //[Microsoft.AspNetCore.Authorization.Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly ProductContext _context;

        public UserProfileController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/UserProfile
        [HttpGet]
        //[Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {


            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        // POST: api/UserProfile
        [HttpPost("PostProduct")]
        public async Task<IActionResult> PostProduct(Product product)
        { 
            if(product.ProductId==0)
            { 
                _context.Products.Add(product);
                }
            else
            {
                _context.Entry(product).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }
       




        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduct(int id, Product product)
        //{
        //    if (id != product.ProductId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        // DELETE: api/UserProfile/id
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

       
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Token_Product.Models;

namespace Token_Product.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductUserController : ControllerBase
    {
        [HttpPost, Route("login")]

        public IActionResult Login([FromBody] Login user)
        {
            if (user == null)
                return BadRequest("Invalid Client Request");

            if (user.Username == "test" && user.Password == "test")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SecretKeyWord@123"));
                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:44384",
                    audience: "https://localhost:44384",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: signingCredentials

                    );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });

            }

            return Unauthorized();
        }
    }
}


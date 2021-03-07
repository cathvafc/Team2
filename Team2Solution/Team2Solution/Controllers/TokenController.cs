using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Team2.Models;


namespace Team2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly APIContext _context;

        public TokenController(IConfiguration config, APIContext context)
        {
            _configuration = config;
            _context = context;
        }


        //POST: api/Token
        //Se recibe una petición POST con el usuario y si existe en el sistema, se genera el token para ese usuario
        [HttpPost]
        public async Task<IActionResult> Post(User _userData)
        {
            
            //Se comprueba que la variable pasada por parámetro tenga datos.
            if (_userData != null && _userData.Email != null && _userData.Password != null)
            {
                //Se obtiene el user de la base de datos con el email y el password.
                var user = await GetUser(_userData.Email, _userData.Password);

                //Si se ha encontrado en la base de datos el usuario se claimea
                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.UserId.ToString()),
                    new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserName", user.UserName),
                    new Claim("Email", user.Email)
                   };

                    //Se genera la clave 
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    //Se aplica el algoritmo de seguridad HASH256
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    //Con la clave generada previamente se obtiene el Token
                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    //Return 200 con todo correcto y el token público
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    //Return 400 si algo ha fallado
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                //Return 400 si algo ha fallado
                return BadRequest();
            }
        }

        //Función que obtiene el user de la base de datos con el email y el password.
        private async Task<User> GetUser(string email, string password)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

        }
    }

  

}

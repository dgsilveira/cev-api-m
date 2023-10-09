﻿using cev_api_m.Domain;
using Microsoft.AspNetCore.Mvc;

namespace cev_api_m.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            var nomeUsuario = "admcev";
            var senhaUsuario = "147852369";

            if (username == nomeUsuario && password == senhaUsuario)
            {
                var token = TokenService.GenerateToken();
                return Ok(token);
            }

            return BadRequest("usuário ou senha inválida");
        }
    }
}

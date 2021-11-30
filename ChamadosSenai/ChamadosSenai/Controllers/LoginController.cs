using ChamadosSenai.Domains;
using ChamadosSenai.Interfaces;
using ChamadosSenai.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ChamadosSenai.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : Controller
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpPost]
        public IActionResult Login(Usuario dados)
        {
            try
            {
                Usuario Login = _usuarioRepository.Login(dados.EmailUsuario, dados.SenhaUsuario);

                if (Login == null)
                {
                    return StatusCode(204, "E-mail e/ou senha não encontrados ou inexistentes");
                }

                var claim = new[]
                {
                    new Claim (JwtRegisteredClaimNames.Email, Login.EmailUsuario),
                    new Claim (JwtRegisteredClaimNames.Jti, Login.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, Login.IdTipoUsuario.ToString())


                };

                var Key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("senha-chamadosSenai"));

                var creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    issuer: "ChamadosSenai.API",
                    audience: "ChamadosSenai.API",
                    claims: claim,
                    expires: DateTime.Now.AddHours(24),
                    signingCredentials: creds
                );

                return Ok
                (
                    new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    }
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
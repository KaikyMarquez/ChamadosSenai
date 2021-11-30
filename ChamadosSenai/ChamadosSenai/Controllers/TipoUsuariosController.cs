using ChamadosSenai.Domains;
using ChamadosSenai.Interfaces;
using ChamadosSenai.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosSenai.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    public class TipoUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _TipoUsuarioRepository { get; set; }

        public TipoUsuariosController()
        {
            _TipoUsuarioRepository = new TipoUsuarioRepository();
        }


        [Authorize(Roles = "4")]
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_TipoUsuarioRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [Authorize(Roles = "4")]
        [HttpGet("idTipoUsuario")]
        public IActionResult BuscarPorId(int idTipoUsuario)
        {
            try
            {
                return Ok(_TipoUsuarioRepository.BuscarPorId(idTipoUsuario));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [Authorize(Roles = "4")]
        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario TipoUsuarioCadastrado)
        {
            try
            {
                _TipoUsuarioRepository.Cadastrar(TipoUsuarioCadastrado);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [Authorize(Roles = "4")]
        [HttpPut("{idTipoUsuario}")]
        public IActionResult Atualizar(int idTipoUsuario, TipoUsuario TipoUsuarioAtualizado)
        {
            try
            {
                _TipoUsuarioRepository.Atualizar(idTipoUsuario, TipoUsuarioAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [Authorize(Roles = "4")]
        [HttpDelete("{idTipoUsuario}")]
        public IActionResult Deletar(int idTipoUsuario)
        {
            try
            {
                _TipoUsuarioRepository.Deletar(idTipoUsuario);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}

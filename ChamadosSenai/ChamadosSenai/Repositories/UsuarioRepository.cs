using ChamadosSenai.Contexts;
using ChamadosSenai.Domains;
using ChamadosSenai.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosSenai.Repositories
{

    public class UsuarioRepository : IUsuarioRepository

    {
        ChamadoContext ctx = new ChamadoContext();

        public void Atualizar(int idUsuario, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioBuscado = BuscarPorId(idUsuario);

            if (UsuarioAtualizado.IdTipoUsuario > 0)
            {
                UsuarioBuscado.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
            }

            if (UsuarioAtualizado.EmailUsuario != null)
            {
                UsuarioBuscado.EmailUsuario = UsuarioAtualizado.EmailUsuario;
            }

            if (UsuarioAtualizado.SenhaUsuario != null)
            {
                UsuarioBuscado.SenhaUsuario = UsuarioAtualizado.SenhaUsuario;
            }

            ctx.Usuarios.Update(UsuarioBuscado);
            ctx.SaveChanges();


        }

        public Usuario BuscarPorId(int idUsuario)
        {
            return ctx.Usuarios.Find(idUsuario);
        }

 
        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int IdUsuario)
        {
            ctx.Usuarios.Remove(BuscarPorId(IdUsuario));
            ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuarios.ToList();
        }


        public Usuario Login(string EmailUsuario, string SenhaUsuario)
        {
            return ctx.Usuarios.FirstOrDefault(l => l.EmailUsuario == EmailUsuario && l.SenhaUsuario == SenhaUsuario);
        }

    }
 }

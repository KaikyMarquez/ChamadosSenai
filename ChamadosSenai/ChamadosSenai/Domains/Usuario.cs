using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ChamadosSenai.Domains
{
    public partial class Usuario
    {
        [Required(ErrorMessage = "TipoUsuario do Usuario é obrigatorio")]
        public int? IdTipoUsuario { get; set; }

        public Guid IdUsuario { get; set; }

        [Required(ErrorMessage = "Email do Usuario é obrigatorio")]
        public string EmailUsuario { get; set; }
        [Required(ErrorMessage = "Senha do Usuario é obrigatorio")]
        public string SenhaUsuario { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}

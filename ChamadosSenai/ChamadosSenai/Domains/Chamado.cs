using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ChamadosSenai.Domains
{
    public partial class Chamado
    {
        public int IdChamado { get; set; }

        [Required(ErrorMessage = "ID do Usuario é obrigatorio")]
        public Guid? IdUsuario { get; set; }
        [Required(ErrorMessage = "ID da Instituiição é obrigatorio")]
        public int? IdInstituicao { get; set; }

        public Guid? IdReceberChamado { get; set; }
        [Required(ErrorMessage = "Sua Localização é obrigatoria")]
        public string Localizacao { get; set; }

        [Required(ErrorMessage = "O Motivo do chamado é obrigatorio")]
        public string Motivo { get; set; }

        public string Descricao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
    }
}

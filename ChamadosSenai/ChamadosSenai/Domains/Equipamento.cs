using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ChamadosSenai.Domains
{
    public partial class Equipamento
    {
        public int IdEquipamento { get; set; }

        [Required(ErrorMessage = "Id da Instituição é obrigatorio")]
        public int? IdInstituicao { get; set; }

        [Required(ErrorMessage = "Nome do equipamento é obrigatorio")]
        public string NomeEquipamento { get; set; }

        public string Descricao { get; set; }

        public virtual Instituicao IdInstituicaoNavigation { get; set; }
    }
}

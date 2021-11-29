using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ChamadosSenai.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Chamados = new HashSet<Chamado>();
            Equipamentos = new HashSet<Equipamento>();
        }

        public Guid? IdUsuario { get; set; }
        public int IdInstituicao { get; set; }

        [Required(ErrorMessage = "Nome da Instituicao da instituição é obrigatorio")]
        public string NomeInstituicao { get; set; }

        [Required(ErrorMessage = "CNPJ da instituição é obrigatorio")]
        [StringLength(14, MinimumLength =14, ErrorMessage = ("O CNPJ deve conter 14 Caracteres"))]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "CEP da localização da instituição é obrigatorio")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = ("O CEP deve conter 8 Caracteres"))]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Pais onde a instituição se localiza é obrigatorio")]
        [StringLength(3, MinimumLength = 50, ErrorMessage = ("O Pais deve conter de 3 a 50 Caracteres"))]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Estado onde a instituição se localiza é obrigatorio")]
        [StringLength(3, MinimumLength = 50, ErrorMessage = ("O Estado deve conter de 3 a 50 Caracteres"))]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Cidade onde a instituição se localiza é obrigatorio")]
        [StringLength(3, MinimumLength = 50, ErrorMessage = ("A Cidade deve conter de 3 a 50 Caracteres"))]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Bairro onde a instituição se localiza é obrigatorio")]
        [StringLength(3, MinimumLength = 50, ErrorMessage = ("O Bairro deve conter de 3 a 50 Caracteres"))]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Numero de onde a instituição se localiza é obrigatorio")]
        [StringLength(9, MinimumLength = 10, ErrorMessage = ("O Numero deve conter de 1 a 10 Caracteres"))]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Endereco (Rua, Avenida e etc) onde a instituição se localiza é obrigatorio")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Telefone da instituição é obrigatorio")]
        [StringLength(9, MinimumLength = 11, ErrorMessage = ("O Telefone deve conter de 9 a 511 Caracteres"))]
        public string Telefone { get; set; }

        public virtual ICollection<Chamado> Chamados { get; set; }
        public virtual ICollection<Equipamento> Equipamentos { get; set; }
    }
}

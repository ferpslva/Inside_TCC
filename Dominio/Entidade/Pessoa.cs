using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(11)]
        public string CPF { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; } = string.Empty;

        public string CEP { get; set; } = string.Empty;

        public string Rua { get; set; } = string.Empty;

        public int Numero { get; set; }

        public string Bairro { get; set; } = string.Empty;

        public string Cidade { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;

        public bool Status { get; set; }

        public virtual List<Inscricao> Inscricoes { get; set; }
            = new List<Inscricao>();

        public virtual List<Saida_Produto> Saidas { get; set; }
            = new List<Saida_Produto>();
    }
}

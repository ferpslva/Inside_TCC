using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class ProfessorDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string CPF { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; } = string.Empty;
        public bool Status { get; set; }

        public string Senha { get; set; } = string.Empty;

    }
}
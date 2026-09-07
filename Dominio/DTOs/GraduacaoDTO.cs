using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class GraduacaoDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public bool Status { get; set; }

        public int IdModalidade { get; set; }

    }
}


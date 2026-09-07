using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int QtdeFinal { get; set; }

        public decimal ValorCredito { get; set; }

        public decimal ValorPix { get; set; }

        public bool Status { get; set; }

        public int IdTamanho { get; set; }

        public int IdTipoProduto { get; set; }
    }
}

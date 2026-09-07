using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int QtdeFinal { get; set; }

        public decimal ValorCredito { get; set; }

        public decimal ValorPix { get; set; }

        public bool Status { get; set; }

        public int IdTamanho { get; set; }
        public virtual Tamanho? Tamanho { get; set; }

        public int IdTipoProduto { get; set; }
        public virtual Tipo_Produto? TipoProduto { get; set; }

        public virtual List<Entrada_Produto> Entradas { get; set; }
            = new List<Entrada_Produto>();

        public virtual List<Saida_Produto> Saidas { get; set; }
            = new List<Saida_Produto>();
    }
}

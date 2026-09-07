using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Eventos
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public int LimiteAlunos { get; set; }

        public string? Poster { get; set; } // caminho da imagem

        public virtual List<Inscricao> Inscricoes { get; set; }
            = new List<Inscricao>();
    }
}

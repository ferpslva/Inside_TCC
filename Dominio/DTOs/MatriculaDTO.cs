using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class MatriculaDTO
    {
        public int Id { get; set; }

        public int IdAluno { get; set; }

        public DateTime Data { get; set; }

        public bool AulaExperimental { get; set; }

        public decimal ValorAula { get; set; }

        public int IdPlano { get; set; }

        public int IdModalidade { get; set; }

        public int IdGraduacao { get; set; }

        public int IdVinculo { get; set; }

        public bool Status { get; set; }
    }
}



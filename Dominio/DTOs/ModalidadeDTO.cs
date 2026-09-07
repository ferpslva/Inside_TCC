namespace Dominio.DTOs
{
    public class ModalidadeDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public bool Status { get; set; }

        public int IdProfessor { get; set; }
    }
}

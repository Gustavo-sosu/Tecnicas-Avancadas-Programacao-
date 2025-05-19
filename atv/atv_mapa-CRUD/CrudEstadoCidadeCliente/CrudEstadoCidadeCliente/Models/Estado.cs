namespace CrudEstadoCidadeCliente.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string EstadoNome { get; set; } = string.Empty;
        public string EstadoSigla { get; set; } = string.Empty;

        public ICollection<Cidade>? Cidades { get; set; }

    }
}

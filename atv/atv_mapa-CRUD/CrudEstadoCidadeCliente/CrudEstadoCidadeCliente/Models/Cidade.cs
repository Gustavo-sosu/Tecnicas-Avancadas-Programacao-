namespace CrudEstadoCidadeCliente.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string CidadeNome { get; set; } = string.Empty;

        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }

    }
}

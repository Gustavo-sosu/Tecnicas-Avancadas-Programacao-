namespace CrudEstadoCidadeCliente.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

    }
}

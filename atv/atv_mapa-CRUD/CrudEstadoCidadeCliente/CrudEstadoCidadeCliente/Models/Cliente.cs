namespace CrudEstadoCidadeCliente.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<Produto>? Produtos { get; set; }

    }
}

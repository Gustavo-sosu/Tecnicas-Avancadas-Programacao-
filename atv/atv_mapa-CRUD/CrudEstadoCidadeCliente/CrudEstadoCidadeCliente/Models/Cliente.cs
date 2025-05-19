namespace CrudEstadoCidadeCliente.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string sex { get; set; }
        public DateOnly DataNasc { get; set; }
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

    }
}

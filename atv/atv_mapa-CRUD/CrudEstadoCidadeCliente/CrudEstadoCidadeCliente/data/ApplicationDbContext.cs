using CrudEstadoCidadeCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEstadoCidadeCliente.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Estado> Estados { get; set; }
}

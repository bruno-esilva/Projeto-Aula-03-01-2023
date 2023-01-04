using Exercicio_03_01_23.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_03_01_23.Context
{
    public class ExercicioContexto : DbContext
    {
        public ExercicioContexto(DbContextOptions<ExercicioContexto> options) : base(options) {}
    }

    public DbSet<Cliente>? Cliente { get; set; };

    public DbSet<Carro>? Carro { get; set; };

    public DbSet<Marca>? Marca { get; set; };

    public DbSet<Modelo>? Modelo { get; set; };

    public DbSet<Configuracao>? Configuracao { get; set; };

    public DbSet<Pedido>? Pedido { get; set; };

}

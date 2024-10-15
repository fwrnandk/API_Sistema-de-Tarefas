using Microsoft.EntityFrameworkCore;
using Sistemas_de_Tarefas.Data.Map;
using Sistemas_de_Tarefas.Models;

namespace Sistemas_de_Tarefas.Data
{
    public class SistemaTarefaDBContex : DbContext
    {
        public SistemaTarefaDBContex(DbContextOptions<SistemaTarefaDBContex> options)
            : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

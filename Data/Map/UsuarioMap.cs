using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistemas_de_Tarefas.Models;

namespace Sistemas_de_Tarefas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> buider)
        {
            buider.HasKey(x => x.id);
            buider.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            buider.Property(x => x.Email).IsRequired().HasMaxLength(255);

        }
    }
}

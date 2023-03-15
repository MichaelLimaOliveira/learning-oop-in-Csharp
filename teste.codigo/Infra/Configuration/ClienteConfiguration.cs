using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace teste.codigo.Infra.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(cliente => cliente.ID);

            builder.HasMany(cliente => cliente.Telefones)
                .WithOne(telefone => telefone.Cliente);

            builder.HasOne(cliente => cliente.Endereco)
                .WithOne(endereco => endereco.Cliente)
                .HasForeignKey<Endereco>(endereco => endereco.Id_Cliente);
        }
    }
}

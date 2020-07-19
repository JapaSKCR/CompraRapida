using CompraRapida.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CompraRapida.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ProdutoId)
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .IsRequired()
                .HasMaxLength(50);

         

        
        }
    }
}

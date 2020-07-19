using CompraRapida.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompraRapida.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey( p => p.Id );
            
            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(p => p.Sobrenome)
               .IsRequired()
               .HasMaxLength(50);

            builder.HasMany(p => p.Pedidos)
                .WithOne( p => p.Usuario);



        }
    }
}

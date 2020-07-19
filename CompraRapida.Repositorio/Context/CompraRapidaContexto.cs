using CompraRapida.Dominio.Entities;
using CompraRapida.Dominio.ObjetoDeValor;
using CompraRapida.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace CompraRapida.Repositorio.Context
{
    public class CompraRapidaContexto : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }


        public CompraRapidaContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                                new FormaPagamento() 
                                    {   
                                        Id = 1, 
                                        Nome = "Boleto", 
                                        Descricao = "Pagamento no Boleto" 
                                    },
                                new FormaPagamento() 
                                    {   
                                        Id = 2, 
                                        Nome = "CartaoCredito", 
                                        Descricao = "Cartão de Crédito" 
                                    },
                                new FormaPagamento() 
                                    { 
                                        Id = 3, 
                                        Nome = "Deposito", 
                                        Descricao = "Depósito" 
                                    });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

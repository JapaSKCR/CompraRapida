using CompraRapida.Dominio.Contracts;
using CompraRapida.Dominio.Entities;
using CompraRapida.Repositorio.Context;

namespace CompraRapida.Repositorio.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {
           
        }


    }
}


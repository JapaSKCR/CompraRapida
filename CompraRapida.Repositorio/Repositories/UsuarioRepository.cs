using CompraRapida.Dominio.Contracts;
using CompraRapida.Dominio.Entities;
using CompraRapida.Repositorio.Context;

namespace CompraRapida.Repositorio.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUserRepository
    {
        public UsuarioRepository(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {
        }
    }
}

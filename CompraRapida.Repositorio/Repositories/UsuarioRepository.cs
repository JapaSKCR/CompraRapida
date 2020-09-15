using CompraRapida.Dominio.Contracts;
using CompraRapida.Dominio.Entities;
using CompraRapida.Repositorio.Context;
using System.Linq;

namespace CompraRapida.Repositorio.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUserRepository
    {
        public UsuarioRepository(CompraRapidaContexto compraRapidaContexto) : base(compraRapidaContexto)
        {

        }

        public Usuario GetUser(string email, string password)
        {
            return CompraRapidaContexto.Usuarios.FirstOrDefault( p => p.Email == email &&  p.Senha == password);
        }
    }
}
